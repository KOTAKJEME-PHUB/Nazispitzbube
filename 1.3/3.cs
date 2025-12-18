static List<int> Task3(int a, int b)
{
    var armstrongs = new List<int>();
    for (int num = Math.Max(1, a); num <= b; num++)
    {
        int original = num;
        int sum = 0;
        int temp = num;
        while (temp > 0)
        {
            int digit = temp % 10;
            sum += digit * digit * digit;
            temp /= 10;
        }
        if (sum == original)
            armstrongs.Add(original);
    }
    return armstrongs;
}