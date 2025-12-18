static (int start, int length) Task2(int[] arr)
{
    if (arr.Length == 0) return (0, 0);

    int maxStart = 0, maxLength = 1;
    int curStart = 0, curLength = 1;

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > arr[i - 1])
        {
            curLength++;
        }
        else
        {
            if (curLength > maxLength)
            {
                maxLength = curLength;
                maxStart = curStart;
            }
            curStart = i;
            curLength = 1;
        }
    }

    // проверка после цикла
    if (curLength > maxLength)
    {
        maxLength = curLength;
        maxStart = curStart;
    }

    return (maxStart, maxLength);
}