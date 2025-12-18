static void Task7()
{
    Console.WriteLine("Введите день, месяц и год (корректную дату):");
    int day = int.Parse(Console.ReadLine());
    int month = int.Parse(Console.ReadLine());
    int year = int.Parse(Console.ReadLine());

    day++;
    if (day > DaysInMonth(month, year))
    {
        day = 1;
        month++;
        if (month > 12)
        {
            month = 1;
            year++;
        }
    }

    Console.WriteLine($"Следующий день: {day:D2}.{month:D2}.{year}");
}