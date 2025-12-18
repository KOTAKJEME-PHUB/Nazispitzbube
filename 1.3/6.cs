static List<int> Task6()
{
    var lucky = new List<int>();
    // Перебираем от 000000 до 999999
    for (int num = 0; num <= 999999; num++)
    {
        int n = num;
        int[] digits = new int[6];
        for (int i = 5; i >= 0; i--)
        {
            digits[i] = n % 10;
            n /= 10;
        }
        int sum1 = digits[0] + digits[1] + digits[2];
        int sum2 = digits[3] + digits[4] + digits[5];
        if (sum1 == sum2)
            lucky.Add(num);
    }
    return lucky; // можно выводить через: $"{num:000000}"
}