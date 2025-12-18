static int Task7(int[] arr)
{
    return new HashSet<int>(arr).Count;
}
// Или через цикл:
// var set = new HashSet<int>();
// foreach (int x in arr) set.Add(x);
// return set.Count;