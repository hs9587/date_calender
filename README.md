# date_calender
# 日付表示
デスクトップに日付数字を配置する。

# 説明
今日の日付をそこそこの大きさでデスクトップに出す  
まあ右上隅に。

協定世界時(UTC)、太平洋時間(PST/PDT切替え)(米西海岸) の日付も追記した。  
(白字で PST, PDT, ミリ秒数も出してるので選択すれば見える)

## 実行
`date.hta`ファイルを実行すると何かその辺に出てくるのでウィンドウの大きさとか場所とか適当に調整する。  
取り敢えず手元の環境でいい感じになるよう大きさ場所設定してある。

ショートカット作ってそのプロパティで引数書くようにすると大きさ初期位置設定できる(字の大きさは固定)。  
引数はカンマ「,」先頭にして、巾、高さ、デスクトップ右端からの戻り、上から下がる分の数字をカンマ区切りで続ける。
引数先頭にもカンマなの注意。

# 背景
Windows7 にデスクトップガジェットというのがあって、いろいろあったんだけど、カレンダーもあった。
普通に月々の表示とかもあったんだけど、日付だけデスクトップの空いてるところに置いとくのが好きだった。

その後ガジェットという枠組みはなくなり Windows10 になり、
やっぱりこの右上隅の空いたあたりに日付があるといい様な気がした。

なんで右上隅が空いているのだろう。  
僕はウィンドウを沢山ひらくのが好きで、そうすると大体のアプリケーションは左上から右下の方に次々のウィンドウを開くので、
デスクトップ上では左下隅と右上隅が残る、空く。  
左下隅はスタート釦に近く、その連想で適度に用のあるショートカットを置いてる。  

## 追記 2019/10/
協定世界時(UTC)、米西海岸の太平洋時間(PST/PDT切替え) の日付も出すようにした。

アマゾンAWS [Service Health Dashboard](https://status.aws.amazon.com/) が太平洋時間表示してて、それが最新今日の日付と知るのに見たかった。  
ついでなんで UTC も出す、そういうのそれなりあるんで。

[説明後述](https://github.com/hs9587/date_calender#utc-ptpstpdt)。

# プログラムについて
## HTA
取り敢えず Ruby で GUI を探したんだけど、2.後半の頃(2019)だと手軽そうなの思いつかなった。
なら HTA(HTML Applications) でいいや、Windows だし。

## 日付だけじゃなくて
日付数字を大きく出すのはいいのだけど、あと曜日は出したい、それは普通の字の大きさでいいや。
その大きさで別の行なら月の数字も出せそう。
年も出せるか。  
曜日は括弧でくくると雰囲気出る、月は一桁なら一桁がいいのでスラッシュ「/」で区切る。

時分秒はなくてもいいのだけど、日付数字自体は日が変わるのに対応したく、適当な間隔で現在時刻見て日付ほか再表示することになる。
日付が分かればいいので分以下くらいの間隔でいいのだけど、見てて実行中とわかるのは安心する。
なら 2,3秒間隔として、それが確認できるように秒は表示しましょう。

年月曜だす幅あるなら、時分秒も出せるか。
時分秒だすとき、プログラム書き始めの頃は二桁左零詰めしてなかったので、
一桁の数字が連なっても分かるようにコロン「:」で区切る、その幅もあるよね。  
([追記](https://github.com/hs9587/date_calender#%E8%BF%BD%E8%A8%98-201910)にて、幅はたくさん)

### 3秒置き
[date.hta#L137](https://github.com/hs9587/date_calender/blob/20191027-0/date.hta#L137)
```javascript
  setInterval('view_date()',2593);
```
ええと 2593 は素数です。
```ruby
$ ruby -r prime -e 'ARGV.first.to_i.prime?.display' 2593
true
```
## 引数のカンマ区切り
[date.hta#L73](https://github.com/hs9587/date_calender/blob/20191027-0/date.hta#L73)
```javascript
  args = date_calender.commandLine.split(',');
```
コマンドライン引数のことなので、はじめ空白区切りを取ってくればいいかと思っていて  
幾つかの Windows環境に置いてるんだけど、置き場所のパス名に空白文字が混じってたりなかったりする、
「My ＜なんとか＞」「＜なんとか＞ and ＜なんとか＞」とか。
そういうときは二重引用符で囲ってあるからなんとかパース出来そうな気もするけど、
空白文字入ってないときは引用符囲ってないのも考慮するとかなのでとちょっと大変。  
なにかライブラリ入れる程大ごとにはしたくないかな、
ライブラリ入れたら後述で工夫した[数字のフォーマット](https://github.com/hs9587/date_calender/blob/master/README.md#%E6%95%B0%E5%AD%97%E3%81%AE%E3%83%95%E3%82%A9%E3%83%BC%E3%83%9E%E3%83%83%E3%83%88)にも便利かな、
ちょっと迷う。

まあライブラリとか大ごとにするのも何なので `.split()` で頑張る。  
余りファイル名パス名に使ってない文字で分けることにすればいいか、
アンダースコア「_」ハイフン(マイナス)「-」は結構使ってるような、
コロン「:」はファイル名に使えないので引数にも使いにくいか、セミコロン「;」はどうだっけ
([ファイル名に使わない方が良い文字](http://www.all.undo.jp/asr/1st/document/01_03.html) AS/R)
。カンマ「,」も同様だった気もしたけどどうかな。

まあカンマ「,」区切りで、
上記の様に自身のファイルパスとも分別しないといけないので引数先頭にも区切り文字を置くことにする。

### 引数既定値
[date.hta#L73](https://github.com/hs9587/date_calender/blob/20191027-0/date.hta#L73)-L76
```javascript
  args = date_calender.commandLine.split(',');

  resizeTo( args[1]||240, args[2]||285 );
  moveTo( screen.width -(args[3]||210), -(args[4]||50) );
```
引数先頭にも区切り文字ということで、 `args[1]` が引数の数値文字列の最初。  
`||` で続けてるのが既定値、引数の文字列がないと論理和をとってその既定値が採用される。
値は手元で良い様なやつ。  
そして `args[2]` 云々と続く。  

`resizeTo()` で実行ウィンドウの大きさ、巾と高さを設定し、  
`moveTo()` でその左上座標の横位置縦位置を設定する、こちらは負号付けて逆向きに数えてる。

### <hta:application />
そもそも引数を見るのは JavaScript の `commandLine` 。そのために冒頭 `hta:application`要素を書いて `id` をつけておく。

[date.hta#L2](https://github.com/hs9587/date_calender/blob/20191027-0/date.hta#L2)-L7
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
月日曜、日付、時分秒の 3行、これらは 3つのパラグラフ(`p`要素)に分けた方がいいのだろうか、それともひとつのパラグラフ(`p`要素)にまとめた方がいいのだろうか。

[date.hta#L12](https://github.com/hs9587/date_calender/blob/20191027-0/date.hta#L12)-L34  
前者の場合、その 3つをまとめるために全体を `div`要素で囲ってみる。

[date.hta#L56](https://github.com/hs9587/date_calender/blob/20191027-0/date.hta#L56)-L69  
後者の場合、3つの各行を `span`要素で囲ってスタイル等指定することになる、今はこちらはコメントアウトしてる。

(
[その後](https://github.com/hs9587/date_calender#%E8%BF%BD%E8%A8%98-201910)
の UTC や PST/PDT の表示では前者に `p`要素を追加した。
)

## スタイルの数字
### 文字の大きさ
大きさの書き方には迷いがある。

相対指定がいいと思うので `font-size: larger;` を使おうかと思うのだけど、一つだけでは大きさが足りないのでネストする。

[date.hta#L17](https://github.com/hs9587/date_calender/blob/20191027-0/date.hta#L17)-L29  
```html
    <span style="font-size: larger;">
    <span style="font-size: larger;">
    <span style="font-size: larger;">
    <span style="font-size: larger;">
    <span style="font-size: larger;">
    <span style="font-size: larger;">
      <span id="view_date">d</span>
    </span>
    </span>
    </span>
    </span>
    </span>
    </span>
```
ちょっと無様。
なら数字一つで指定すると `font-size: 7em;` か

[date.hta#L62](https://github.com/hs9587/date_calender/blob/20191027-0/date.hta#L62)  
```html
    <span id="view_date" style="font-size: 7em;">d</span>
```
まあ `7em` も相対指定とはいえる。  
今のところ後者はコメントアウト方面にしてる。

### 上下の間隔(行間)
真ん中の日付数字行、文字大きくしてるのでその分行間も広がってしまうの少し詰める。

全体、`body`上辺は詰める、 `body`の `margin` は内側なの注意  
[date.hta#L9](https://github.com/hs9587/date_calender/blob/20191027-0/date.hta#L9)
```html
<body style="padding-top: 0; margin-top: 0;">
```

1行目、年月曜は `line-height: 1.5;`  
[date.hta#L12](https://github.com/hs9587/date_calender/blob/20191027-0/date.hta#L12)
```html
  <p style="line-height: 1.5; margin: 0; border: 1px solid white;">
```

日付数字は `line-height: 0.8;`  
[date.hta#L16](https://github.com/hs9587/date_calender/blob/20191027-0/date.hta#L16)
```html
  <p style="line-height: 0.8; margin: 0; border: 1px solid white;">
```

時分秒は `line-height:   0;`  
[date.hta#L32](https://github.com/hs9587/date_calender/blob/20191027-0/date.hta#L32)
```html
  <p style="line-height:   0; margin: 0; border: 1px solid white;">
```
まあ試行錯誤の結果なんだけど、これ以上は動かしにくい
1. 3行目の高さ 0 になってる、これを少しでも大きくすると、
2. 行間保つには 2行目の高さ減らす必要があって
3. そうすると 1行目の高さ増やさないといけないが
4. 全体、`body`上辺 0 で減らしようがないので
5. 上の余白が増えることになる

逆もしかりなので、まあこんなもんかと。

コメントアウト方面([date.hta#L56](https://github.com/hs9587/date_calender/blob/20191027-0/date.hta#L56)-69)も同様。

各スタイル項の ` border: 1px solid white;` 、今は `white` にしてるので見えないが、いろいろ調整するとき領域が見える様に枠線色付けた時の名残り。

(
[その後](https://github.com/hs9587/date_calender#%E8%BF%BD%E8%A8%98-201910)
の UTC や PST/PDT の表示でも `line-height: 1.5;` と `line-height:   0;` 交互に。
)

## 時間の表示
[date.hta#L107](https://github.com/hs9587/date_calender/blob/20191027-0/date.hta#L107)-113
```javascript
    document.getElementById('view_date')   .innerHTML =      now.getDate();
    document.getElementById('view_year')   .innerHTML =  (''+now.getFullYear()).slice(-2);
    document.getElementById('view_month')  .innerHTML =      now.getMonth()+1;
    document.getElementById('view_day')    .innerHTML = week[now.getDay()];
    document.getElementById('view_hour')   .innerHTML = ('0'+now.getHours())   .slice(-2);
    document.getElementById('view_minutes').innerHTML = ('0'+now.getMinutes()) .slice(-2);
    document.getElementById('view_seconds').innerHTML = ('0'+now.getSeconds()) .slice(-2);
```
`getElementById()` でとってきた要素に時間を表示する、要素とってくるとき地に何か書いてないと取れないの注意  
[date.hta#L23](https://github.com/hs9587/date_calender/blob/20191027-0/date.hta#L23)
```html
      <span id="view_date">d</span>
```
の「d」とか。

### 年
年をとってくるには `getFullYear()` を使う、4桁年号。  
`getYear()` はもう勧められてないとのこと。

### 数字のフォーマット
JavaScript には暗黙の型変換がある。
- ~~[上記](https://github.com/hs9587/date_calender/blob/master/README.md#%E5%B9%B4)より 4桁でとれた年はやっぱり二桁だけ取る。~~
- 月は 0 始まりなの調整。
- 曜は漢字表記がいいので別に配列を作っておいて頑張る。
- 時分秒は二桁左零詰めにしたい。

二桁左零詰めのフォーマット、数値に文字列の `'0'` を左から繋げると文字列になり、 `slice(-2)` で右から 2文字とる。  
~~年には左零無くていいけど、空文字列を繋げると文字列になるから。~~

## UTC, PT(PST/PDT)
協定世界時(UTC) はJavaScript の日付メソッドにそういうのがある。

太平洋時間(PST/PDT) はそこからの時差を手で調整する。
- https://www.time-j.net/WorldTime/Country/US
- https://24timezones.com/taimuzon/pt

より
- 太平洋標準時 PST、UTC-0800
- 太平洋夏時間 PDT、UTC-0700
- 夏時間、3月の第2日曜日午前2:00～11月第1日曜日午前2:00
  - 特に記述が見あたらないが、切替えまでの時間帯でのその時刻と思うことにする。
  - 境目がどうなのかもないが、等号なしの不等号で比べよう 一文字少ないし。

### 夏時間の切替え
ローカルタイムの時差や夏時間は OS や JavaScript がなんとかしてくれるけど、
余所の時間帯のは自分で何とかする。

「3月の第2日曜日午前2:00～11月第1日曜日午前2:00」

1. 第2日曜日とか第1日曜日とか JavaScript でどうすれば
2. Date.parse() で月初日を作って、一日ずつ進めて曜日を数えるとか

ちょっと大変そうなので、
別に計算した境界日時の起算時からのミリ秒数との比較で切り替えることにする。
取り合えず十年分くらい。


[date.hta#L92](https://github.com/hs9587/date_calender/blob/20191027-0/date.hta#L92)-103
```javascript
if (1552212000000 < now.getTime() && now.getTime() < 1572771600000) { pt_zone = 'PDT' } // 19
if (1583661600000 < now.getTime() && now.getTime() < 1604221200000) { pt_zone = 'PDT' } // 20
  ……
if (1899367200000 < now.getTime() && now.getTime() < 1919926800000) { pt_zone = 'PDT' } // 30

```
数字は次の `erb`([pdt_check.erb](https://github.com/hs9587/date_calender/blob/master/pdt_check.erb)) で計算した、第2、第1日曜の記述注意。

[date.hta#L88](https://github.com/hs9587/date_calender/blob/20191027-0/date.hta#L88)-90
```erb
<% require 'time'; require 'active_support/time' %>
<% (19..30).each do |y| %>
if (<%= (Time.parse (Time.parse("20#{y}-03-01").next_week(:sunday)+7200).to_s.sub('+0900', 'PST')).to_i*1000 %> < now.getTime() && now.getTime() < <%= (Time.parse (Time.parse("20#{y}-11-01").next_week(:sunday).ago(1.week)+7200).to_s.sub('+0900', 'PDT')).to_i*1000 %>) { pt_zone = 'PDT' } // <%= y %> <% end %>

```
```(19..30)``` 取り敢えず 2030年まで、その頃になったらまた。
月初日```03-01```, ```11-01``` 文字列からパース、
```Time.parse``` は```require 'time'``` より。
```.next_week(:sunday)```,
```.ago(1.week)``` は active_support より、
第1日曜は直接そういうのなくて翌週日曜から1週間戻る。
```7200```秒は2時間。
得られた時刻を文字列化すると JST(符号数字表記)になるので
```sub('+0900', 'PST')```,
```sub('+0900', 'PDT')``` でそれぞれの時間帯の表記に、
そしてまたパース。

