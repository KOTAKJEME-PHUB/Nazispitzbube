static void Task5()
{
    Console.WriteLine("Введите координаты ферзя (например: d5):");
    string s1 = Console.ReadLine().ToLower();
    Console.WriteLine("Введите координаты фигуры противника:");
    string s2 = Console.ReadLine().ToLower();

    int x1 = s1[0] - 'a' + 1, y1 = int.Parse(s1[1].ToString());
    int x2 = s2[0] - 'a' + 1, y2 = int.Parse(s2[1].ToString());

    bool sameRow = y1 == y2;
    bool sameCol = x1 == x2;
    bool sameDiag = Math.Abs(x1 - x2) == Math.Abs(y1 - y2);

    Console.WriteLine(sameRow || sameCol || sameDiag ? "Да" : "Нет");
}