static int[] Task8(double[] times)
{
    if (times.Length < 4)
        throw new ArgumentException("Недостаточно спортсменов");

    // Получаем индексы, отсортированные по времени
    var indices = Enumerable.Range(0, times.Length)
                            .OrderBy(i => times[i])
                            .Take(4)
                            .ToArray();
    return indices;
}

// Использование: 
// double[] times = { 10.2, 9.8, 10.5, 9.9, 10.0, 9.7 };
// int[] best = Task8(times); // → [5, 1, 3, 4]