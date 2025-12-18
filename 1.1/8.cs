static string Rubles(int n)
{
    int mod100 = n % 100;
    int mod10 = n % 10;

    if (mod100 >= 11 && mod100 <= 14)
        return "рублей";
    return mod10 switch
    {
        1 => "рубль",
        2 or 3 or 4 => "рубля",
        _ => "рублей"
    };
}

static void Task8()
{
    Console.WriteLine("Введите число от 1 до 999:");
    int n = int.Parse(Console.ReadLine());
    if (n < 1 || n > 999)
    {
        Console.WriteLine("Число вне диапазона.");
        return;
    }

    Console.WriteLine($"{n} {Rubles(n)}");
}