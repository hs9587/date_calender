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



## JScript

## C# (up to C# 5)
