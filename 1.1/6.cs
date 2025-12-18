static bool IsLeapYear(int year) => year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

static int DaysInMonth(int month, int year)
{
    int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    if (month == 2 && IsLeapYear(year)) return 29;
    return days[month - 1];
}

static void Task6()
{
    Console.WriteLine("Введите день, месяц и год:");
    int day = int.Parse(Console.ReadLine());
    int month = int.Parse(Console.ReadLine());
    int year = int.Parse(Console.ReadLine());

    bool valid = month >= 1 && month <= 12 &&
                 day >= 1 && day <= DaysInMonth(month, year) &&
                 year >= 1; // можно ограничить год, например >= 1900

    Console.WriteLine(valid ? "Корректная дата" : "Некорректная дата");
}