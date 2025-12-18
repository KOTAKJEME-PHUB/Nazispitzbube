static int Task6(int[] arr)
{
    if (arr.Length == 0) throw new ArgumentException("Массив пуст");
    var count = new Dictionary<int, int>();
    foreach (int x in arr)
        count[x] = count.GetValueOrDefault(x, 0) + 1;

    return count.OrderByDescending(kv => kv.Value).First().Key;
}