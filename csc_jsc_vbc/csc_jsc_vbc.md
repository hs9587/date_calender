# date_calender VB, JScript, C#
ある日、Windows に標準で各種コンパイラが付属してることを知った、(2024/9/中)
```cmd
c:\Windows\Microsoft.NET\Framework64\v4.0.30319\
  csc
  jsc
  vbc
```
Visual C# Compiler (C#5まで)、JScript コンパイラ、Visual Basic コンパイラ
です。64 のついてないところには 32bit版のコンパイラもある。

ので、ちょっとその辺で date_calender をやってみます。  
2024/9/15(日)

## VB Visual Basic
date_calender の VB版、次のように ChatGPTに相談してプログラムの原型ができた。
```
VB(Visual Basic)で、ちいさなWindpwだして、現在日時秒をひょうじするのどうしたらいいかなあ。
```
```
vbc でコンパイルしてエラーがでないようにして
```
```
error BC30002: 型 'Size' が定義されていません。
error BC30002: 型 'Point' が定義されていません。
といわれるんだけど
```
```
曜日も表示したい、括弧でくくって日本語一文字
```
```
日付の数字だけすごく大きく表示したい
```
```
年/月/ までは普通のサイズでいいんだけどな
```
```
曜日は、年月の直後にしたい
```
```
最後に UTC の/月/日 時、と、PDTの /月/日 時 を
```
そんでコンパイル手順
```cmd
c:\Windows\Microsoft.NET\Framework64\v4.0.30319\vbc /target:winexe /r:System.Windows.Forms.dll /r:System.Drawing.dll dateVB.vb
```
そのソースを調整、ChatGP の助けも借りながら、表示詳細やセンタリングとか夏時間のこと、Windowのサイズもギリギリにして、最大化最小化釦もなくしアイコンも。

左肩のアイコン用の画像も ChatGPT に作ってもらって(webp)からトリミングとファイル形式変更して .icoファイルにした。ChatGPT からの画像は背景グレーだったのは、Windows付属の フォト で背景を削除したらなんとかなった、いいように背景を自動識別してくれた。  
そしてそのアイコンを .exe 自体にも適用するのは vbcコンパイラのオプション /win32icon でした。
```cmd
date_calender\csc_jsc_vbc>c:\Windows\Microsoft.NET\Framework64\v4.0.30319\vbc /target:winexe /r:System.Windows.Forms.dll /r:System.Drawing.dll /win32icon:date.ico dateVB.vb
```

さらに、Windowの位置調整もする、引数から読むのは .hta版を範とする。具体的なコードは ChatGPTの助け。



## JScript

## C# (up to C# 5)
