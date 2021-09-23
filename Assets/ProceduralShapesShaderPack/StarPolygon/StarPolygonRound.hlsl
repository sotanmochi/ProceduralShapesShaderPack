//
// Star Polygon
//
// References:
//  [1] Is there an equation to describe regular polygons? (https://math.stackexchange.com/a/4160104)
//  [2] Как нарисовать звезду (и не только) в полярных координатах (https://habr.com/ru/post/519954/)
//  [3] 正多角形とスピログラフの数式 (https://slpr.sakura.ne.jp/qp/polygon-spirograph/#star2d)
//
void StarPolygonRound_float(float2 PolarCoordinates, int N, float K, out float Output)
{
    float rsq = PolarCoordinates.x * PolarCoordinates.x;
    float angle = 2.0 * PI * PolarCoordinates.y;

    float an = 3.0 * PI / (2.0 * N);
    float asink = asin(K);
    float asinkcos = asin(K * cos(N * angle));

    float d = cos(asink / N + an) / cos(asinkcos / N + an);
    float dsq = d * d;

    Output = 1 - step(dsq, rsq);
}