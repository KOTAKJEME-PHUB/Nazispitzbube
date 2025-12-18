static int Task9(int[] a, int[] b)
{
    var setB = new HashSet<int>(b);
    int count = 0;
    foreach (int x in a)
        if (setB.Contains(x))
            count++;
    return count;
}