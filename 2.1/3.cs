static (int start, int length) Task3(int[] arr)
{
    if (arr.Length == 0) return (0, 0);
    int bestStart = 0, bestLen = 1;

    for (int center = 0; center < arr.Length; center++)
    {
        // нечётная длина: центр — один элемент
        int l = center, r = center;
        while (l >= 0 && r < arr.Length && arr[l] == arr[r])
        {
            int len = r - l + 1;
            if (len > bestLen)
            {
                bestLen = len;
                bestStart = l;
            }
            l--; r++;
        }

        // чётная длина: центр — между двумя
        l = center; r = center + 1;
        while (l >= 0 && r < arr.Length && arr[l] == arr[r])
        {
            int len = r - l + 1;
            if (len > bestLen)
            {
                bestLen = len;
                bestStart = l;
            }
            l--; r++;
        }
    }

    return (bestStart, bestLen);
}