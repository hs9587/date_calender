# date_calender
# 日付表示
デスクトップに日付数字を配置する。

# 説明
今日の日付をそこそこの大きさでデスクトップに出す  
まあ右上隅に。

## 実行
`date.hta` ファイル実行すると何かその辺に出てくるのでウィンドウの大きさとか場所とか適当に調整する。  
取り敢えず手元の環境でいい感じになるよう大きさ場所設定してある。

ショートカット作ってそのプロパティで引数書くようにすると大きさ初期位置設定できる(字の大きさは固定)。  
引数はカンマ先頭にその後、巾、高さ、デスクトップ右端からの戻り、上から下がる分の数字をカンマ区切りで続ける。
引数先頭にもカンマなの注意。

# 背景やプログラムについて
Windows7 にデスクトップガジェットというのがあって、いろいろあったんだけど、カレンダーもあった。
普通の月々の表示とかもあったんだけど、日付だげデスクトップの空いてるところに置いとくのが好きだった。

その後ガジェットという枠組みはなくなり Windows10 になり、
やっぱりこの右上の空いたあたりに日付があるといい様な気がした。

なんで右上隅が空いているのだろう。  
僕はウィンドウを沢山ひらくのが好きで、そうすると大体のアプリケーションは左上から右下の方に次々のウィンドウを開くので、
デスクトップ上では左下隅と右上隅が残ることになる、  
左下隅はスタート釦に近く、その連想で適度に用のあるショートカットを置いてる。  

## HTA
取り敢えず Ruby で GUI を探したんだけど、2.後半の頃(2019)だと手軽そうなの思いつかなった。
なら HTA (HTML Applications) でいいや、Windows だし。

## 日付だけじゃなくて
日付数字を大きく出すのはいいのだけど、あと曜日は出したい、それは普通の字の大きさでいいや。
その大きさで別の行なら月の数字も出せそう。
年も出せるか。  
曜日は括弧でくくると雰囲気出る、月は一桁なら一桁がいいのでスラッシュ「/」で区切る。

時分秒はなくてもいいのだけど、日付数字自体は日が変わるのに対応したく、適当な間隔で現在時間見て日付ほか再表示することになる。
日付が分かればいいので分以下くらいの間隔でいいのだけど、見てて実行中とわかるのは安心する。
なら 2,3秒間隔として、それが確認できるように秒は表示しましょう。

年月曜だす幅あるなら、時分秒も出せるか。
時分秒だすとき、プログラム書き始めの頃は二桁左零詰めしてなかったので、
一桁の数字が連なっても分かるようにコロン「:」で区切る、その幅もあるよね。

### 3秒置き
[date.hta#L74](https://github.com/hs9587/date_calender/blob/20190817-0/date.hta#L74)
```javascript
  setInterval('view_date()',2593);
```
ええと `2593` は素数です。
```ruby
$ ruby -r prime -e 'ARGV.first.to_i.prime?.display' 2593
true
```
## 引数のカンマ区切り
[date.hta#L55](https://github.com/hs9587/date_calender/blob/20190817-0/date.hta#L55)
```javascript
  args = date_calender.commandLine.split(',');
```
コマンドライン引数のことなので、はじめ空白区切りを取ってくればいいかと思っていて  
幾つかの Windows環境に置いてるんだけど、置き場所のパス名に空白文字が混じってたりなかったりする、
「My ＜なんとか＞」「＜なんとか＞ and ＜なんとか＞」とか。
そのときは二重引用符で囲ってあるからなんとかパース出来そうな気もするけど、、
空白文字入ってないときは引用符かこってないのも考慮するとなるとちょっと大変。  
なにかライブラリ入れる程大ごとにはしたくないかな、
ライブラリ入れたら後述で工夫した数字のフォーマットにも便利かな、
ちょっと迷う。

まあライブラリとか大ごとにするのも何なので`.split()`で頑張る。  
余りファイル名パス名に使ってない文字で分けることにすればいいか、
アンダースコア「_」ハイフン(マイナス)「-」は結構使ってるような、
コロン「:」はファイル名に使えないので引数にも使いにくいか、セミコロン「;」はどうだっけ
([ファイル名に使わない方が良い文字](http://www.all.undo.jp/asr/1st/document/01_03.html) AS/R)
。カンマ「,」も同様だった気もしたけどどうかな。

まあカンマ「,」区切りで、
上記の様に自身のファイルパスとも分別しないといけないので引数先頭にも区切り文字を置くことにする。

### 引数既定値
[date.hta#L55](https://github.com/hs9587/date_calender/blob/20190817-0/date.hta#L55)-L58
```javascript
  args = date_calender.commandLine.split(',');

  resizeTo( args[1]||240, args[2]||250 );
  moveTo( screen.width -(args[3]||210), -(args[4]||50) );
```
引数先頭にも区切り文字ということで、`args[1]`が引数の数値文字列の最初。  
`||`で続けてるのが既定値、引数の文字列がないと論理和をとってその既定値が採用される。
値は手元で良い様なやつ。  
そして`args[2]`云々と続く。  

`resizeTo()`で実行ウィンドウの大きさ、巾と高さを設定し、  
`moveTo()`でその左上座標の横位置縦位置を設定する、こちらは負号付けて逆向きに数えてる。

### <hta:application />
そもそも引数を見るのは JavaScript の`commandLine`。そのために冒頭`hta:application`要素を書いて`id`をつけておく。

[date.hta#L2](https://github.com/hs9587/date_calender/blob/20190817-0/date.hta#L2)-L7
```javascript
<hta:application
  id="date_calender"
  maximizeButton="no"
  minimizeButton="no"
  scroll="no"
 />
```
それに続く設定で実行ウィンドウのふち飾りをシンプルに。

## html の事
html の書き方には迷いがある。  
月日曜、日付、時分秒の 3行、これらは 3つのパラグラフ(p要素)に分けた方がいいのだろうか、それともひとつのパラグラフ(p要素)にまとめた方がいいのだろうか。

[date.hta#L11](https://github.com/hs9587/date_calender/blob/20190817-0/date.hta#L11)-L35  
前者の場合、その 3つをまとめるために 全体を div要素で囲ってみる。

[date.hta#L37](https://github.com/hs9587/date_calender/blob/20190817-0/date.hta#L37)-L52  
後者の場合、3つの各行を span要素で囲ってスタイル等指定することになる、今はこちらはコメントアウトしている。

## スタイルの数字

