static void Task1()
{
    Console.WriteLine("Введите три целых числа:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());

    int evenCount = (a % 2 == 0 ? 1 : 0) +
                    (b % 2 == 0 ? 1 : 0) +
                    (c % 2 == 0 ? 1 : 0);

    Console.WriteLine(evenCount == 1 ? "истина" : "ложь");
}