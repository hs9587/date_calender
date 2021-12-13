<!DOCTYPE html>
<html>
<head>
  <title>MathML my test</title>
  <script async src="https://cdnjs.cloudflare.com/ajax/libs/mathjax/2.7.5/MathJax.js?config=TeX-MML-AM_CHTML"></script>
</head>
<body>
<p>
<code>none</code>要素というのもあるけど
<br />
<math>
  <mrow>
    <mi>a</mi>
    <none />
    <mi>s</mi>
  </mrow>
</math>
<br />
普通の文脈では特に何も無い
</p>

<p>
<math>
  <mtable>
    <mtr>
      <mtd>
        <mtext>(1)</mtext>
      </mtd>
      <mtd>
        <mi>i</mi>
      </mtd>
    </mtr>
  </mtable>
</math>
<math>
  <mtable side="rightoverlap">
    <mlabeledtr>
      <mtd>
        <mtext>(1)</mtext>
      </mtd>
      <mtd>
        <mi>i</mi>
      </mtd>
    </mlabeledtr>
  </mtable>
</math>
式番号は <code>mlabeledtr</code> の最初の <code>mtd</code> に、
それで右についたりもするが
</p>

<p>
式を縦に配置するのは <code>mtable</code> を使う、
今のところほかに無いし。
<br />
そのとき、どこを縦に合わせ、ど辺をずらして調整していいのか、指示が必要で、
<code>maligngroup</code>, <code>malignmark</code> とか使う
</p>

<p>
<code>mtable</code>要素の属性 <code>alignmentscope="false"</code> の謎、<del>後述</del>
</p>

<p>
というわけで、頑張ってスペースとかで調整したこれを
</p>

qwer
<p style="margin-left: 2em;">
<math>
  <mrow>
    <mspace width="1.5em">

    <mfenced>
      <mrow>
        <mover><mi>OP</mi><mo>&rarr;</mo></mover>
        <mo>-</mo>
        <mover><mi>OH</mi><mo>&rarr;</mo></mover>
      </mrow>
    </mfenced>

    <mo>&sdot;</mo>
    <mfenced>
      <mtable>
        <mtr><mtd><mi>a</mi></mtd></mtr>
        <mtr><mtd><mi>b</mi></mtd></mtr>
      </mtable>
    </mfenced>

    <mo>=</mo>

    <mi>t</mi>
    <mo>&it;</mo>
    <mfenced>
      <mtable>
        <mtr><mtd><mi>a</mi></mtd></mtr>
        <mtr><mtd><mi>b</mi></mtd></mtr>
      </mtable>
    </mfenced>
    <mo>&sdot;</mo>
    <mfenced>
      <mtable>
        <mtr><mtd><mi>a</mi></mtd></mtr>
        <mtr><mtd><mi>b</mi></mtd></mtr>
      </mtable>
    </mfenced>

    <mspace width="2em"/>
    <mtext>内積を取った</mtext>
</math>
<br />
<math>
  <mrow>
    <mover><mi>OP</mi><mo>&rarr;</mo></mover>
    <mo>&sdot;</mo>
    <mfenced>
      <mtable>
        <mtr><mtd><mi>a</mi></mtd></mtr>
        <mtr><mtd><mi>b</mi></mtd></mtr>
      </mtable>
    </mfenced>

    <mo>-</mo>

    <mover><mi>OH</mi><mo>&rarr;</mo></mover>
    <mo>&sdot;</mo>
    <mfenced>
      <mtable>
        <mtr><mtd><mi>a</mi></mtd></mtr>
        <mtr><mtd><mi>b</mi></mtd></mtr>
      </mtable>
    </mfenced>

    <mo>=</mo>

    <mi>t</mi>
    <mo>&it;</mo>
    <mfenced>
      <mtable>
        <mtr><mtd><mi>a</mi></mtd></mtr>
        <mtr><mtd><mi>b</mi></mtd></mtr>
      </mtable>
    </mfenced>
    <mo>&sdot;</mo>
    <mfenced>
      <mtable>
        <mtr><mtd><mi>a</mi></mtd></mtr>
        <mtr><mtd><mi>b</mi></mtd></mtr>
      </mtable>
    </mfenced>

    <mspace width="2em"/>
    <mtext>カッコを外して展開した</mtext>
</math>
<br />
<math>
  <mrow>
    <mspace width="5em">

    <mover><mi>OP</mi><mo>&rarr;</mo></mover>

    <mo>&sdot;</mo>
    <mfenced>
      <mtable>
        <mtr><mtd><mi>a</mi></mtd></mtr>
        <mtr><mtd><mi>b</mi></mtd></mtr>
      </mtable>
    </mfenced>

    <mo>=</mo>

    <mi>t</mi>
    <mo>&it;</mo>
    <mfenced>
      <mtable>
        <mtr><mtd><mi>a</mi></mtd></mtr>
        <mtr><mtd><mi>b</mi></mtd></mtr>
      </mtable>
    </mfenced>
    <mo>&sdot;</mo>
    <mfenced>
      <mtable>
        <mtr><mtd><mi>a</mi></mtd></mtr>
        <mtr><mtd><mi>b</mi></mtd></mtr>
      </mtable>
    </mfenced>

    <mspace width="2em"/>
    <mover><mi>OH</mi><mo>&rarr;</mo></mover>
    <mtext>
      &thinsp;
      と
    </mtext>
    <mfenced>
      <mtable>
        <mtr><mtd><mi>a</mi></mtd></mtr>
        <mtr><mtd><mi>b</mi></mtd></mtr>
      </mtable>
    </mfenced>
    <mtext>
      &thinsp;
      は垂直なので内積は
      &thinsp;
    </mtext>
    <mn>0</mn>
</math>
<br />
<math>
  <mrow>
    <mspace width="4em">

    <mfenced>
      <mtable>
        <mtr><mtd><msub><mi>x</mi><mn>0</mn></msub></mtd></mtr>
        <mtr><mtd><msub><mi>y</mi><mn>0</mn></msub></mtd></mtr>
      </mtable>
    </mfenced>

    <mo>&sdot;</mo>
    <mfenced>
      <mtable>
        <mtr><mtd><mi>a</mi></mtd></mtr>
        <mtr><mtd><mi>b</mi></mtd></mtr>
      </mtable>
    </mfenced>

    <mo>=</mo>

    <mi>t</mi>
    <mo>&it;</mo>
    <mfenced>
      <mtable>
        <mtr><mtd><mi>a</mi></mtd></mtr>
        <mtr><mtd><mi>b</mi></mtd></mtr>
      </mtable>
    </mfenced>
    <mo>&sdot;</mo>
    <mfenced>
      <mtable>
        <mtr><mtd><mi>a</mi></mtd></mtr>
        <mtr><mtd><mi>b</mi></mtd></mtr>
      </mtable>
    </mfenced>

    <mspace width="2em"/>
    <mover><mi>OP</mi><mo>&rarr;</mo></mover>
    <mo>=</mo>
    <mfenced>
      <mtable>
        <mtr><mtd><msub><mi>x</mi><mn>0</mn></msub></mtd></mtr>
        <mtr><mtd><msub><mi>y</mi><mn>0</mn></msub></mtd></mtr>
      </mtable>
    </mfenced>
    <mtext>
      &thinsp;
      だから
    </mtext>
</math>
<br />
<math>
  <mrow>
    <mspace width="6em">

    <msub><mi>x</mi><mn>0</mn></msub>
    <mo>&it;</mo>
    <mi>a</mi>

    <mo>+</mo>

    <msub><mi>y</mi><mn>0</mn></msub>
    <mo>&it;</mo>
    <mi>b</mi>

    <mo>=</mo>

    <mi>t</mi>
    <mo>&it;</mo>
    <mfenced>
      <mrow>
        <mi>a</mi>
        <mo>&it;</mo>
        <mi>a</mi>

        <mo>+</mo>

        <mi>b</mi>
        <mo>&it;</mo>
        <mi>b</mi>
      </mrow>
    </mfenced>

    <mspace width="2em"/>
    <mtext>内積を成分で計算した</mtext>
</math>
<br />
<math>
  <mrow>
    <mspace width="6em">

    <mi>a</mi>
    <mo>&it;</mo>
    <msub><mi>x</mi><mn>0</mn></msub>

    <mo>+</mo>

    <mi>b</mi>
    <mo>&it;</mo>
    <msub><mi>y</mi><mn>0</mn></msub>

    <mo>=</mo>

    <mi>t</mi>
    <mo>&it;</mo>
    <mfenced>
      <mrow>
        <msup><mi>a</mi><mn>2</mn></msup>
        <mo>+</mo>
        <msup><mi>b</mi><mn>2</mn></msup>
      </mrow>
    </mfenced>

    <mspace width="2em"/>
    <mtext>整理した</mtext>
</math>
<br />
<math>
  <mrow>
    <mspace width="6em">

    <mi>t</mi>
    <mo>&it;</mo>
    <mfenced>
      <mrow>
        <msup><mi>a</mi><mn>2</mn></msup>
        <mo>+</mo>
        <msup><mi>b</mi><mn>2</mn></msup>
      </mrow>
    </mfenced>

    <mo>=</mo>

    <mi>a</mi>
    <mo>&it;</mo>
    <msub><mi>x</mi><mn>0</mn></msub>

    <mo>+</mo>

    <mi>b</mi>
    <mo>&it;</mo>
    <msub><mi>y</mi><mn>0</mn></msub>

    <mspace width="2em"/>
    <mtext>両辺を交換した</mtext>
  </mrow>
</math>
</p>

<p>
<code>malign云々</code> でやってみる
</p>

asdf
<p style="margin-left: 2em;">
<math>
  <mtable groupalign="{left cneter right right right}">
    <mtr>
      <mtd>
        <mrow>
          <maligngroup />

          <mfenced>
            <mrow>
              <mover><mi>OP</mi><mo>&rarr;</mo></mover>
              <mo>-</mo>
              <mover><mi>OH</mi><mo>&rarr;</mo></mover>
            </mrow>
          </mfenced>
      
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
          <maligngroup />
          <malignmark />
          <mo>=</mo>
          <maligngroup />
      
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
          <maligngroup />
          <mtext>内積を取った</mtext>
          <maligngroup />
        </mrow>
      </mtd>
    </mtr>
    <mtr>
      <mtd>
        <mrow>
          <maligngroup />

          <mover><mi>OP</mi><mo>&rarr;</mo></mover>
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
          <mo>-</mo>
      
          <mover><mi>OH</mi><mo>&rarr;</mo></mover>
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
          <maligngroup />
          <malignmark />
          <mo>=</mo>
          <maligngroup />
      
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
          <maligngroup />
          <mtext>カッコを外して展開した</mtext>
          <maligngroup />
        </mrow>
      </mtd>
    </mtr>
    <mtr>
      <mtd>
        <mrow>
          <maligngroup />
      
          <mover><mi>OP</mi><mo>&rarr;</mo></mover>
      
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
          <maligngroup />
          <malignmark />
          <mo>=</mo>
          <maligngroup />
      
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
          <maligngroup />
          <mover><mi>OH</mi><mo>&rarr;</mo></mover>
          <mtext>
            &thinsp;
            と
          </mtext>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
          <mtext>
            &thinsp;
            は垂直なので内積は
            &thinsp;
          </mtext>
          <mn>0</mn>
          <maligngroup />
        </mrow>
      </mtd>
    </mtr>
    <mtr>
      <mtd>
        <mrow>
          <maligngroup />
  
          <mfenced>
            <mtable>
              <mtr><mtd><msub><mi>x</mi><mn>0</mn></msub></mtd></mtr>
              <mtr><mtd><msub><mi>y</mi><mn>0</mn></msub></mtd></mtr>
            </mtable>
          </mfenced>
      
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
          <maligngroup />
          <malignmark />
          <mo>=</mo>
          <maligngroup />
      
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
          <maligngroup />
          <mover><mi>OP</mi><mo>&rarr;</mo></mover>
          <mo>=</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><msub><mi>x</mi><mn>0</mn></msub></mtd></mtr>
              <mtr><mtd><msub><mi>y</mi><mn>0</mn></msub></mtd></mtr>
            </mtable>
          </mfenced>
          <mtext>
            &thinsp;
            だから
          </mtext>
          <maligngroup />
        </mrow>
      </mtd>
    </mtr>
    <mtr>
      <mtd>
        <mrow>
          <maligngroup />
 
          <msub><mi>x</mi><mn>0</mn></msub>
          <mo>&it;</mo>
          <mi>a</mi>
      
          <mo>+</mo>
      
          <msub><mi>y</mi><mn>0</mn></msub>
          <mo>&it;</mo>
          <mi>b</mi>
      
          <maligngroup />
          <malignmark />
          <mo>=</mo>
          <maligngroup />
      
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mrow>
              <mi>a</mi>
              <mo>&it;</mo>
              <mi>a</mi>
      
              <mo>+</mo>
      
              <mi>b</mi>
              <mo>&it;</mo>
              <mi>b</mi>
            </mrow>
          </mfenced>
      
          <maligngroup />
          <mtext>内積を成分で計算した</mtext>
          <maligngroup />
        </mrow>
      </mtd>
    </mtr>
    <mtr>
      <mtd>
        <mrow>
          <maligngroup />
  
          <mi>a</mi>
          <mo>&it;</mo>
          <msub><mi>x</mi><mn>0</mn></msub>
      
          <mo>+</mo>
      
          <mi>b</mi>
          <mo>&it;</mo>
          <msub><mi>y</mi><mn>0</mn></msub>
      
          <maligngroup />
          <malignmark />
          <mo>=</mo>
          <maligngroup />
      
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mrow>
              <msup><mi>a</mi><mn>2</mn></msup>
              <mo>+</mo>
              <msup><mi>b</mi><mn>2</mn></msup>
            </mrow>
          </mfenced>
      
          <maligngroup />
          <mtext>整理した</mtext>
          <maligngroup />
        </mrow>
      </mtd>
    </mtr>
    <mtr>
      <mtd>
        <mrow>
          <maligngroup />
  
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mrow>
              <msup><mi>a</mi><mn>2</mn></msup>
              <mo>+</mo>
              <msup><mi>b</mi><mn>2</mn></msup>
            </mrow>
          </mfenced>
      
          <maligngroup />
          <malignmark />
          <mo>=</mo>
          <maligngroup />
      
          <mi>a</mi>
          <mo>&it;</mo>
          <msub><mi>x</mi><mn>0</mn></msub>
      
          <mo>+</mo>
      
          <mi>b</mi>
          <mo>&it;</mo>
          <msub><mi>y</mi><mn>0</mn></msub>
      
          <maligngroup />
          <mtext>両辺を交換した</mtext>
          <maligngroup />
        </mrow>
      </mtd>
    </mtr>
  </mtable>
</math>
</p>
zxcv
<p style="margin-left: 2em;">
<a href="https://www.w3.org/TR/MathML3/chapter3.html#id.3.5.5.8">
3.5.5.8 MathML representation of an alignment example</a>
(MathML Version 3.0) より、例示をコピペ 
<math>
<mtable groupalign=
         "{decimalpoint left left decimalpoint left left decimalpoint}">
  <mtr>
    <mtd>
      <mrow>
        <mrow>
          <mrow>
            <maligngroup/>
            <mn> 8.44 </mn>
            <mo> &#x2062;<!--INVISIBLE TIMES--> </mo>
            <maligngroup/>
            <mi> x </mi>
          </mrow>
          <maligngroup/>
          <mo> + </mo>
          <mrow>
            <maligngroup/>
            <mn> 55 </mn>
            <mo> &#x2062;<!--INVISIBLE TIMES--> </mo>
            <maligngroup/>
            <mi> y </mi>
          </mrow>
        </mrow>
      <maligngroup/>
      <mo> = </mo>
      <maligngroup/>
      <mn> 0 </mn>
    </mrow>
    </mtd>
  </mtr>
  <mtr>
    <mtd>
      <mrow>
        <mrow>
          <mrow>
            <maligngroup/>
            <mn> 3.1 </mn>
            <mo> &#x2062;<!--INVISIBLE TIMES--> </mo>
            <maligngroup/>
            <mi> x </mi>
          </mrow>
          <maligngroup/>
          <mo> - </mo>
          <mrow>
            <maligngroup/>
            <mn> 0.7 </mn>
            <mo> &#x2062;<!--INVISIBLE TIMES--> </mo>
            <maligngroup/>
            <mi> y </mi>
          </mrow>
        </mrow>
        <maligngroup/>
        <mo> = </mo>
        <maligngroup/>
        <mrow>
          <mo> - </mo>
          <mn> 1.1 </mn>
        </mrow>
      </mrow>
    </mtd>
  </mtr>
</mtable>
</math>
</p>
<!--
<p>
<code>malignmark</code> は <code>edge</code>属性の、
<code>right</code>で直左要素の右端、
 <code>left</code>で直右要素の左端、
を示す、既定値は <code>left</code> 直右要素の左端
</p>
 -->
<p>
<a href="https://www.w3.org/TR/MathML3/chapter3.html#presm.malign">
Alignment Markers &lt;maligngroup/&gt;, &lt;malignmark/&gt;</a>
は実装が効かないみたい
</p>
<p>
<a href="https://www.mathjax.org/#gettingstarted">
MathJax Getting Started</a>
より、バージョン上がってた(2.7.5 &lt;- 2.7.2)(2019/6/15現在)の調整しても
<code>malign云々</code> 効かない感じ変わらず、
<code>latest</code> というのもあるのか
</p>
<p>
malign云々、最小限でもう少し試す
</p>
poiu
<p style="margin-left: 2em;">
<math>
  <mtable>
    <mtr>
      <mtd>
        <maligngroup>
          <mi>asdf</mi>
        </maligngroup>
        <maligngroup>
          <mo>=</mo>
        </maligngroup>
        <maligngroup>
          <mn>0</mn>
        </maligngroup>
      </mtd>
    </mtr>
    <mtr>
      <mtd>
        <maligngroup>
          <mi>q</mi>
        </maligngroup>
        <maligngroup>
          <mo>=</mo>
        </maligngroup>
        <maligngroup>
          <mn>1.1</mn>
        </maligngroup>
      </mtd>
    </mtr>
  </mtable>
</math>
</p>
<p>
やっぱならない
</p>
<p style="margin-left: 2em;">
<math alignmentscope="true">
  <mtable alignmentscope="true">
    <mtr>
      <mtd>
        <maligngroup>
          <mi>asdf</mi>
        </maligngroup>
        <maligngroup>
          <mo>=</mo>
        </maligngroup>
        <maligngroup>
          <mn>0</mn>
        </maligngroup>
      </mtd>
    </mtr>
    <mtr>
      <mtd>
        <maligngroup>
          <mi>q</mi>
        </maligngroup>
        <maligngroup>
          <mo>=</mo>
        </maligngroup>
        <maligngroup>
          <mn>1.1</mn>
        </maligngroup>
      </mtd>
    </mtr>
  </mtable>
</math>
</p>
<p>
<code>alignmentscope="true"</code> 明示的に設定してみたけどならない
</p>

<p>
なら <code>mtable</code>で <code>mtd</code>で位置合わせ
</p>
lkjh
<p style="margin-left: 2em;">
<math>
  <mtable columnalign="right center left left" columnspacing="0.5ex 0.5ex 1em">
    <mtr>
      <mtd>
        <mrow>
          <mfenced>
            <mrow>
              <mover><mi>OP</mi><mo>&rarr;</mo></mover>
              <mo>-</mo>
              <mover><mi>OH</mi><mo>&rarr;</mo></mover>
            </mrow>
          </mfenced>
      
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mo>=</mo>
        </mrow>
      </mtd>
      <mtd>
        <mrow>
  
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mtext>内積を取った</mtext>
        </mrow>
      </mtd>
    </mtr>
    <mtr>
      <mtd>
        <mrow>
          <mover><mi>OP</mi><mo>&rarr;</mo></mover>
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
          <mo>-</mo>
      
          <mover><mi>OH</mi><mo>&rarr;</mo></mover>
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mo>=</mo>
        </mrow>
      </mtd>
      <mtd>
        <mrow>
  
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mtext>カッコを外して展開した</mtext>
        </mrow>
      </mtd>
    </mtr>
    <mtr>
      <mtd>
        <mrow>
          <mover><mi>OP</mi><mo>&rarr;</mo></mover>
      
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mo>=</mo>
        </mrow>
      </mtd>
      <mtd>
        <mrow>
  
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mover><mi>OH</mi><mo>&rarr;</mo></mover>
          <mtext>
            &thinsp;
            と
          </mtext>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
          <mtext>
            &thinsp;
            は垂直なので内積は
            &thinsp;
          </mtext>
          <mn>0</mn>
        </mrow>
      </mtd>
    </mtr>
    <mtr>
      <mtd>
        <mrow>
          <mfenced>
            <mtable>
              <mtr><mtd><msub><mi>x</mi><mn>0</mn></msub></mtd></mtr>
              <mtr><mtd><msub><mi>y</mi><mn>0</mn></msub></mtd></mtr>
            </mtable>
          </mfenced>
      
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mo>=</mo>
        </mrow>
      </mtd>
      <mtd>
        <mrow>
 
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mover><mi>OP</mi><mo>&rarr;</mo></mover>
          <mo>=</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><msub><mi>x</mi><mn>0</mn></msub></mtd></mtr>
              <mtr><mtd><msub><mi>y</mi><mn>0</mn></msub></mtd></mtr>
            </mtable>
          </mfenced>
          <mtext>
            &thinsp;
            だから
          </mtext>
        </mrow>
      </mtd>
    </mtr>
    <mtr>
      <mtd>
        <mrow>
          <msub><mi>x</mi><mn>0</mn></msub>
          <mo>&it;</mo>
          <mi>a</mi>
      
          <mo>+</mo>
      
          <msub><mi>y</mi><mn>0</mn></msub>
          <mo>&it;</mo>
          <mi>b</mi>
      
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mo>=</mo>
        </mrow>
      </mtd>
      <mtd>
        <mrow>
 
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mrow>
              <mi>a</mi>
              <mo>&it;</mo>
              <mi>a</mi>
      
              <mo>+</mo>
      
              <mi>b</mi>
              <mo>&it;</mo>
              <mi>b</mi>
            </mrow>
          </mfenced>
      
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mtext>内積を成分で計算した</mtext>
        </mrow>
      </mtd>
    </mtr>
    <mtr>
      <mtd>
        <mrow>
          <mi>a</mi>
          <mo>&it;</mo>
          <msub><mi>x</mi><mn>0</mn></msub>
      
          <mo>+</mo>
      
          <mi>b</mi>
          <mo>&it;</mo>
          <msub><mi>y</mi><mn>0</mn></msub>
      
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mo>=</mo>
        </mrow>
      </mtd>
      <mtd>
        <mrow>
 
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mrow>
              <msup><mi>a</mi><mn>2</mn></msup>
              <mo>+</mo>
              <msup><mi>b</mi><mn>2</mn></msup>
            </mrow>
          </mfenced>
      
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mtext>整理した</mtext>
        </mrow>
      </mtd>
    </mtr>
    <mtr>
      <mtd>
        <mrow>
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mrow>
              <msup><mi>a</mi><mn>2</mn></msup>
              <mo>+</mo>
              <msup><mi>b</mi><mn>2</mn></msup>
            </mrow>
          </mfenced>
 
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mo>=</mo>
        </mrow>
      </mtd>
      <mtd>
        <mrow>
 
          <mi>a</mi>
          <mo>&it;</mo>
          <msub><mi>x</mi><mn>0</mn></msub>
      
          <mo>+</mo>
      
          <mi>b</mi>
          <mo>&it;</mo>
          <msub><mi>y</mi><mn>0</mn></msub>
      
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mtext>両辺を交換した</mtext>
        </mrow>
      </mtd>
    </mtr>
  </mtable>
</math>
</p>

<p>
式説明 <code>mlabeledtr</code> で
</p>
mnbv
<p style="margin-left: 2em;">
<math>
  <mtable columnalign="right center left" columnspacing="0.5ex 0.5ex">
    <mlabeledtr>
      <mtd>
        <mrow>
          <mtext>内積を取った</mtext>
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mfenced>
            <mrow>
              <mover><mi>OP</mi><mo>&rarr;</mo></mover>
              <mo>-</mo>
              <mover><mi>OH</mi><mo>&rarr;</mo></mover>
            </mrow>
          </mfenced>
      
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mo>=</mo>
        </mrow>
      </mtd>
      <mtd>
        <mrow>
  
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
        </mrow>
      </mtd>
    </mlabeledtr>
    </mtr>
    <mlabeledtr>
      <mtd>
        <mrow>
          <mtext>カッコを外して展開した</mtext>
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mover><mi>OP</mi><mo>&rarr;</mo></mover>
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
          <mo>-</mo>
      
          <mover><mi>OH</mi><mo>&rarr;</mo></mover>
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mo>=</mo>
        </mrow>
      </mtd>
      <mtd>
        <mrow>
  
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
        </mrow>
      </mtd>
    </mlabeledtr>
    <mlabeledtr>
      <mtd>
        <mrow>
          <mover><mi>OH</mi><mo>&rarr;</mo></mover>
          <mtext>
            &thinsp;
            と
          </mtext>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          <mfenced>
              <mi>a</mi>
              <mi>b</mi>
          </mfenced>
          <mrow>
            <mo>(</mo>
            <mo>)</mo>
          </mrow>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>

          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
            </mtable>
          </mfenced>

        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mover><mi>OP</mi><mo>&rarr;</mo></mover>
      
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mo>=</mo>
        </mrow>
      </mtd>
      <mtd>
        <mrow>
  
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
        </mrow>
      </mtd>
    </mlabeledtr>
    <mlabeledtr>
      <mtd>
        <mtext>
        </mtext>
      </mtd>
      <mtd>
        <mrow>
          <mfenced>
            <mtable>
              <mtr><mtd><msub><mi>x</mi><mn>0</mn></msub></mtd></mtr>
              <mtr><mtd><msub><mi>y</mi><mn>0</mn></msub></mtd></mtr>
            </mtable>
          </mfenced>
      
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mo>=</mo>
        </mrow>
      </mtd>
      <mtd>
        <mrow>
 
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
          <mo>&sdot;</mo>
          <mfenced>
            <mtable>
              <mtr><mtd><mi>a</mi></mtd></mtr>
              <mtr><mtd><mi>b</mi></mtd></mtr>
            </mtable>
          </mfenced>
      
        </mrow>
      </mtd>
    </mlabeledtr>
    <mtr>
      <mtd>
        <mrow>
          <msub><mi>x</mi><mn>0</mn></msub>
          <mo>&it;</mo>
          <mi>a</mi>
      
          <mo>+</mo>
      
          <msub><mi>y</mi><mn>0</mn></msub>
          <mo>&it;</mo>
          <mi>b</mi>
      
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mo>=</mo>
        </mrow>
      </mtd>
      <mtd>
        <mrow>
 
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mrow>
              <mi>a</mi>
              <mo>&it;</mo>
              <mi>a</mi>
      
              <mo>+</mo>
      
              <mi>b</mi>
              <mo>&it;</mo>
              <mi>b</mi>
            </mrow>
          </mfenced>
      
        </mrow>
      </mtd>
    </mtr>
    <mtr>
      <mtd>
        <mrow>
          <mi>a</mi>
          <mo>&it;</mo>
          <msub><mi>x</mi><mn>0</mn></msub>
      
          <mo>+</mo>
      
          <mi>b</mi>
          <mo>&it;</mo>
          <msub><mi>y</mi><mn>0</mn></msub>
      
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mo>=</mo>
        </mrow>
      </mtd>
      <mtd>
        <mrow>
 
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mrow>
              <msup><mi>a</mi><mn>2</mn></msup>
              <mo>+</mo>
              <msup><mi>b</mi><mn>2</mn></msup>
            </mrow>
          </mfenced>
      
        </mrow>
      </mtd>
    </mtr>
    <mtr>
      <mtd>
        <mrow>
          <mi>t</mi>
          <mo>&it;</mo>
          <mfenced>
            <mrow>
              <msup><mi>a</mi><mn>2</mn></msup>
              <mo>+</mo>
              <msup><mi>b</mi><mn>2</mn></msup>
            </mrow>
          </mfenced>
 
        </mrow>
      </mtd>
      <mtd>
        <mrow>
          <mo>=</mo>
        </mrow>
      </mtd>
      <mtd>
        <mrow>
 
          <mi>a</mi>
          <mo>&it;</mo>
          <msub><mi>x</mi><mn>0</mn></msub>
      
          <mo>+</mo>
      
          <mi>b</mi>
          <mo>&it;</mo>
          <msub><mi>y</mi><mn>0</mn></msub>
      
        </mrow>
      </mtd>
    </mtr>
  </mtable>
</math>
</p>
<ul>
  <li>ラベルセルの中で 2行のテーブルに括弧をつけようとするとエラー</li>
  <li>ラベルセルにラベル以上の長さの説明は適さない感じ</li>
  <li>そしてテーブル本体は中央に寄る</li>
</ul>
<p>
というわけで、 <code>mlabeledtr</code>  はちょっと使いにくいかな
</p>

<p>
そして横引きを考える
</p>
tyg
<p style="margin-left: 2em;">
<math columnalign="right left" columnspacing="0">
  <mtable>
    <mtr>
      <mtd>
        <mtext>……</mtext>
      </mtd>
      <mtd>
        <mtext>三点リーダ</mtext>
      </mtd>
    </mtr>
    <mtr>
      <mtd rowalign="center">
        <mtext>……</mtext>
      </mtd>
      <mtd>
        <mtext>rowalign center</mtext>
      </mtd>
    </mtr>
    <mtr>
      <mtd>
        <mtext>&#x2026;&#x2026;</mtext>
      </mtd>
      <mtd>
        <mtext>horizontal ellipsis</mtext>
      </mtd>
    </mtr>
    <mtr>
      <mtd>
        <mtext>&#x22EF;&#x22EF;</mtext>
      </mtd>
      <mtd>
        <mtext>midline horizontal ellipsis</mtext>
      </mtd>
    </mtr>
    <mtr>
      <mtd>
        <mtext>&#x22EF;&thinsp;&#x22EF;</mtext>
      </mtd>
      <mtd>
        <mtext>thinsp</mtext>
      </mtd>
    </mtr>
    <mtr>
      <mtd>
        <mfrac><mspace width="3em"><none /></mfrac>
      </mtd>
      <mtd>
        <mtext>mfrac mspace none</mtext>
      </mtd>
    </mtr>
  </mtable>
</math>
</p>
<ul>
  <li><code>rowalign</code> は効かない、というか変な感じ</li>
  <li>それなら中程にくるのは midline horizontal ellipsis &amp;#x22EF; </li>
  <li>いずれにしても点の配置はムラ</li>
    <ul>
      <li><code>thinsp</code> 挟むとなんとか</li>
    </ul>
  <li>線なら目的外使用だけど <code>mfrac</code> か</li>
</ul>

</body>
</html>
