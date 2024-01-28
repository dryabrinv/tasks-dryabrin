int[] arr = [5, 1, 3, 4, 0, 9, 7];

Console.Write("Нечетные числа: ");

for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 != 0)
    {
        Console.Write($"{i} ");
    }
}
