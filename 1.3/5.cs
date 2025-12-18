static double Task5(double x, int n)
{
    if (n < 0)
        throw new ArgumentException("Степень n должна быть неотрицательной (n >= 0).");

    double result = 1.0;
    for (int i = 0; i < n; i++)
    {
        result *= x;
    }
    return result;
}