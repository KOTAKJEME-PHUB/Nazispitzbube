static bool Task11(int[] a, int[] b)
{
    var setA = new HashSet<int>(a);
    var setB = new HashSet<int>(b);
    return setA.SetEquals(setB);
}