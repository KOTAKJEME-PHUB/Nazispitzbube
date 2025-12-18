static List<int> Task4_Sequence(int[] arr)
{
    if (arr.Length == 0) return new List<int>();

    int n = arr.Length;
    int[] dp = new int[n];
    int[] parent = new int[n];
    Array.Fill(dp, 1);
    for (int i = 0; i < n; i++) parent[i] = -1;

    for (int i = 1; i < n; i++)
        for (int j = 0; j < i; j++)
            if (arr[j] < arr[i] && dp[j] + 1 > dp[i])
            {
                dp[i] = dp[j] + 1;
                parent[i] = j;
            }

    // Находим индекс максимума
    int idx = Array.IndexOf(dp, dp.Max());
    var lis = new List<int>();
    while (idx != -1)
    {
        lis.Add(arr[idx]);
        idx = parent[idx];
    }
    lis.Reverse();
    return lis;
}