static void Task4()
{
    Console.WriteLine("Введите координаты коня (например: e4):");
    string s1 = Console.ReadLine().ToLower();
    Console.WriteLine("Введите координаты фигуры противника:");
    string s2 = Console.ReadLine().ToLower();

    int x1 = s1[0] - 'a' + 1, y1 = int.Parse(s1[1].ToString());
    int x2 = s2[0] - 'a' + 1, y2 = int.Parse(s2[1].ToString());

    int dx = Math.Abs(x1 - x2);
    int dy = Math.Abs(y1 - y2);

    bool beats = (dx == 1 && dy == 2) || (dx == 2 && dy == 1);
    Console.WriteLine(beats ? "Да" : "Нет");
}