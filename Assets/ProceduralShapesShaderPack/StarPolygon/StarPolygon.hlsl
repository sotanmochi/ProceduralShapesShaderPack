//
// Star Polygon
//
// References:
//  [1] Is there an equation to describe regular polygons? (https://math.stackexchange.com/a/4160104)
//  [2] Как нарисовать звезду (и не только) в полярных координатах (https://habr.com/ru/post/519954/)
//  [3] 正多角形とスピログラフの数式 (https://slpr.sakura.ne.jp/qp/polygon-spirograph/#star2d)
//
void StarPolygon_float(float2 PolarCoordinates, int N, out float Output)
{
    float rsq = PolarCoordinates.x * PolarCoordinates.x;
    float angle = 2.0 * PI * PolarCoordinates.y;

    float an = 2.0 * PI / N;
    float d = cos(an) / cos(an - acos(cos(N * angle)) / N);
    float dsq = d * d;

    Output = 1 - step(dsq, rsq);
}