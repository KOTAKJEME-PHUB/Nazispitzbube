static long Task1(int n)
{
    long sum = 0;
    for (int k = 1; k <= n; k++)
    {
        long term = 1;
        for (int j = k; j <= 2 * k; j++)
        {
            term *= j;
            // Опционально: проверка переполнения (если n > ~10, быстро растёт!)
        }
        sum += term;
    }
    return sum;
}