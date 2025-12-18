static void Task1()
{
    Console.Write("Введите целое число: ");
    int number = Math.Abs(int.Parse(Console.ReadLine())); // Убираем знак для упрощения

    Console.Write("Введите цифру (0-9): ");
    int digit = int.Parse(Console.ReadLine());

    bool found = false;
    if (number == 0 && digit == 0) // Особый случай: число 0 и цифра 0
        found = true;
    else
    {
        while (number > 0)
        {
            if (number % 10 == digit)
            {
                found = true;
                break;
            }
            number /= 10;
        }
    }

    Console.WriteLine(found ? "Цифра входит в число" : "Цифра не входит в число");
}