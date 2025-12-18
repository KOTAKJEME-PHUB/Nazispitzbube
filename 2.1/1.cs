static bool Task1(int[] arr)
{
    if (arr.Length <= 1) return true;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] <= arr[i - 1]) // строго возрастающая? → "<="; неубывающая → "<"
            return false;
    }
    return true;
}