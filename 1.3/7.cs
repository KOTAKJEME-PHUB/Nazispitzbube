static long Task7(int n)
{
    if (n <= 0) throw new ArgumentException("n должно быть >= 1");
    if (n == 1 || n == 2) return 1;

    long f1 = 1, f2 = 1;
    long fn = 0;
    for (int i = 3; i <= n; i++)
    {
        fn = f1 + f2;
        f1 = f2;
        f2 = fn;
    }
    return fn;
}