# Star Polygon

## 極座標を用いた星の描き方について
極座標における正多角形の公式は以下のように表せる [1, 2]。

$
\rho = \frac{\text{cos} \left( \frac{2 \, \text{arcsin} (k) \, + \, \pi m}{2n} \right)}
            {\text{cos} \left( \frac{2 \, \text{arcsin} (k \, \text{cos} \left( n \phi \right)) \, + \, \pi m}{2n} \right)}
\, \cdots \, (1)
$

$\rho$：動径  
$\phi$：角度  
$n$：凸型の頂点の数  
$m$：  
$k$：

星型多角形を描くために $k = 1, m = 3$ の場合の式を導出する。

式(1)に $k = 1$ を代入すると、
$
\rho = \frac{\text{cos} \left( \frac{2 \, \text{arcsin} (1) \, + \, \pi m}{2n} \right)}
            {\text{cos} \left( \frac{2 \, \text{arcsin} (\text{cos} \left( n \phi \right)) \, + \, \pi m}{2n} \right)}
$

$\text{arcsin}(1) = \frac{\pi}{2}, \, \text{arcsin}\, x = \frac{\pi}{2} - \text{arccos}\, x$ より
$
\rho = \frac{\text{cos} \left( \frac{\left( m + 1 \right) \, \pi}{2n} \right)}
            {\text{cos} \left( \frac{\left( m + 1 \right) \, \pi}{2n} \, - \, \frac{\text{arccos} \left( \text{cos} \left( n \phi \right) \right)}{n} \right)} 
$

さらに $m = 3$ を代入すると、
$
\rho = \frac{\text{cos} \left( \frac{2 \, \pi}{n} \right)}
            {\text{cos} \left( \frac{2 \, \pi}{n} \, - \, \frac{\text{arccos} \left(\text{cos} \left( n \phi \right) \right)}{n} \right)}
\, \cdots \, (2)
$
となる。

式(2)を用いることで、N芒星（$N > 5$）を描くことができる。  
式(2)は[3]に示されている星型多角形の式を極方程式の形で表したものと等しいことが分かる。

また、$k$ の値を変化させる（$0 \le k \le 1$）ことによって、図形の丸みを変化させることができる。  
$k$ の値を変化させる場合には、式(1)に $m = 3$ のみを代入した以下の式を用いる。
$
\rho = \frac{\text{cos} \left( \frac{\text{arcsin} (k)}{n} \, + \, \frac{3 \pi}{2n} \right)}
            {\text{cos} \left( \frac{\text{arcsin} (k \, \text{cos} \left( n \phi \right))}{n} \, + \, \frac{3 \pi}{2n} \right)}
\, \cdots \, (3)
$

## 参考文献
[1] Is there an equation to describe regular polygons? (https://math.stackexchange.com/a/4160104)  
[2] Как нарисовать звезду (и не только) в полярных координатах (https://habr.com/ru/post/519954/)  
[3] 正多角形とスピログラフの数式 (https://slpr.sakura.ne.jp/qp/polygon-spirograph/#star2d)  
