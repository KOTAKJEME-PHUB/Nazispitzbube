static void Task3()
{
    Console.WriteLine("Введите три целых числа:");
    int[] arr = new int[3];
    for (int i = 0; i < 3; i++)
        arr[i] = int.Parse(Console.ReadLine());

    Array.Sort(arr);
    Console.WriteLine($"По возрастанию: {arr[0]} {arr[1]} {arr[2]}");
}