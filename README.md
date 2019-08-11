# date_calender
# 日付表示
デスクトップに日付数字を配置する。

# 説明
今日の日付をそこそこの大きさでデスクトップに出す  
まあ右上隅に。

## 実行
.hta ファイル実行すると何かその辺に出てくるのでウィンドウの大きさとか場所とか適当に調整する。  
取り敢えず手元の環境でいい感じになるよう大きさ場所設定してある。

ショートカット作ってそのプロパティで引数書くようにすると大きさ初期位置設定できる。  
引数はカンマ先頭にその後、巾、高さ、デスクトップ右端からの戻り、上から下がる分の数字をカンマ区切りで続ける。
引数先頭にもカンマなの注意。

# ソースについて


# 背景
Windows7 にデスクトップガジェットというのがあって、いろいろあったんだけど、カレンダーもあった。
普通の月々の表示とかもあったんだけど、日付だげデスクトップの空いてるところに置いとくのが好きだった。

その後ガジェットという枠組みはなくなり Windows10 になり、
やっぱりこの右上の空いたあたりに日付があるといい様な気がした。

なんで右上隅が空いているのだろう。  
僕はウィンドウを沢山ひらくのが好きで、そうすろ大体のアプリケーションは左上から右下の方に次々のウィンドウを開くので、
デスクトップ上では左下隅と右上隅が残ることになる、  
左下隅はスタート釦に近く、その連想で適度に用のあるショートカットを置いてる。  

## HTA
取り敢えず Ruby で GUI を探したんだけど、2.後半の頃(2019)だと手軽そうなの思いつかなった。
なら HTA (HTML Applications) でいいや、Windows だし。

## スタイルの数字

## 引数のカンマ区切り

## 日付だけじゃなくて
日付数字を大きく出すのはいいのだけど、あと曜日は出したい、それは普通の字の大きさでいいや。
その大きさで別の行なら月の数字も出せそう。
年も出せるか。  
曜日は括弧でくくると雰囲気出る、月は一桁なら一桁がいいのでスラッシュ「/」で区切る。

時分秒はなくてもいいのだけど、日付数字自体は日が変わるのに対応したく、適当な間隔で時間見ることになる。
日付が分かればいいので分以下くらいの間隔でいいのだけど、見てて実行中とわかるのは安心する。
なら 2,3秒間隔として、それが確認できるように秒は表示しましょう。

年月曜だす幅あるなら、時分秒も出せるか。
時分秒だすとき、プログラム書き始めの頃は二桁左零詰めしてなかったので、
一桁の数字が連なっても分かるように間にコロン「:」を入れる。その幅もあるよね。

### 3秒置き
ええと `2593` は素数です。
```
ruby -r prime -e 'ARGV.first.to_i.prime?.display'
```
