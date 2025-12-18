static long Task2(int n)
{
    if (n <= 0) return 1; // по соглашению 0!! = 1, (-1)!! = 1
    long result = 1;
    int step = 2;
    int start = (n % 2 == 0) ? 2 : 1;

    for (int i = start; i <= n; i += step)
    {
        result *= i;
    }
    return result;
}