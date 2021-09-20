void RoseSineCurve_float(float2 PolarCoordinates, float A, int N, float Power, out float Output)
{
    float radius = PolarCoordinates.x;
    float angle = 2 * PI * PolarCoordinates.y;

    // The polar equation of the rose curve
    // https://mathworld.wolfram.com/RoseCurve.html
    float d = A * pow(abs(sin(N * angle)), Power);

    Output = 1 - step(d, radius);
}