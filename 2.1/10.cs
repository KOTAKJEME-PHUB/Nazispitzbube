static bool Task10(int[] arr)
{
    var set = new HashSet<int>();
    foreach (int x in arr)
        if (!set.Add(x)) // Add возвращает false, если уже есть
            return false;
    return true;
}