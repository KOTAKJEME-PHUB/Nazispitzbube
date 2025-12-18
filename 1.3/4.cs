static int SumProperDivisors(int n)
{
    if (n <= 1) return 0;
    int sum = 1; // 1 всегда делитель (кроме n=1)
    for (int i = 2; i * i <= n; i++)
    {
        if (n % i == 0)
        {
            sum += i;
            if (i != n / i) sum += n / i;
        }
    }
    return sum;
}

static List<(int, int)> Task4(int a, int b)
{
    var pairs = new List<(int, int)>();
    // Перебираем x в [a, b], ищем y = sumDiv(x), проверяем условия
    for (int x = a; x <= b; x++)
    {
        int y = SumProperDivisors(x);
        if (y > x && y <= b && SumProperDivisors(y) == x) // y > x — чтобы не повторять (220,284) и (284,220)
        {
            pairs.Add((x, y));
        }
    }
    return pairs;
}