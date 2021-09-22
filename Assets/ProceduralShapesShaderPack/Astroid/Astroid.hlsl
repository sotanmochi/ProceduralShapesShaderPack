void Astroid_float(float2 PolarCoordinates, float Scale, out float Output)
{
    float radius = PolarCoordinates.x;
    float angle = 2 * PI * PolarCoordinates.y;

    //
    // The polar equation of the astroid
    // https://mathworld.wolfram.com/Astroid.html
    //
    // The tangent term has been changed to the absolute value, 
    // because appropriate values cannot be obtained in the range which the tangent value is negative.
    //
    // Visualization of functions using Graphtoy
    // https://graphtoy.com/?f1(x,t)=abs(tan(x))&v1=true&f2(x,t)=tan(x)&v2=true&f3(x,t)=1/pow(1.0+pow(abs(tan(x)),2.0/3.0),3.0/2.0)&v3=true&f4(x,t)=1/pow(1.0+pow(tan(x),2.0/3.0),3.0/2.0)&v4=true&f5(x,t)=rcp(cos(x))&v5=true&f6(x,t)=abs(rcp(cos(x)))/pow(1.0+pow(abs(tan(x)),2.0/3.0),3.0/2.0)&v6=true&grid=true&coords=-0.012845206058364214,0.5423485884679891,2.7697272426562733
    //
    float secant = 1 / cos(angle);
    float tangent = abs(tan(angle));
    float d = abs(secant) / pow(1.0 + pow(tangent, 2.0 / 3.0), 3.0 / 2.0);

    Output = 1 - step(d * Scale, radius);
}