static void Task2()
{
    Console.Write("Введите целое число: ");
    int number = int.Parse(Console.ReadLine());
    int original = number;

    // Обработка отрицательных чисел
    bool isNegative = number < 0;
    number = Math.Abs(number);

    int reversed = 0;
    while (number > 0)
    {
        reversed = reversed * 10 + number % 10;
        number /= 10;
    }

    if (isNegative)
        reversed = -reversed;

    Console.WriteLine($"Число {original} в обратном порядке: {reversed}");
}