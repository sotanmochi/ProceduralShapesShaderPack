void Cardioid_float(float2 PolarCoordinates, float a, out float Output)
{
    float radius = PolarCoordinates.x;
    float angle = 2 * PI * PolarCoordinates.y;

    // The polar equation of the cardioid
    // https://mathworld.wolfram.com/Cardioid.html
    float d = a * (1 - cos(angle));

    Output = 1 - step(d, radius);
}