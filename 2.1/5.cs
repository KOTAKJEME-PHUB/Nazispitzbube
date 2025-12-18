static int Task5(int[] arr)
{
    var count = new Dictionary<int, int>();
    foreach (int x in arr)
        count[x] = count.GetValueOrDefault(x, 0) + 1;

    return count.Values.Count(c => c == 1);
}