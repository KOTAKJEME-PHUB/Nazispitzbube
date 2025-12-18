static bool IsFibonacci(int n)
{
    if (n <= 0) return false;
    if (n == 1) return true; // F1 и F2 = 1

    int f1 = 1, f2 = 1;
    int fn;
    while (true)
    {
        fn = f1 + f2;
        if (fn == n) return true;
        if (fn > n) return false;
        f1 = f2;
        f2 = fn;
    }
}

static void Task3()
{
    Console.Write("Введите целое число: ");
    int number = int.Parse(Console.ReadLine());

    if (IsFibonacci(number))
        Console.WriteLine($"{number} — число Фибоначчи.");
    else
        Console.WriteLine($"{number} — не число Фибоначчи.");
}