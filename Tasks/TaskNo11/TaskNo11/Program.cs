int[] arr = [5, 1, 3, 8, 9, 10, 0, 1];
int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    sum += arr[i];
}

Console.WriteLine($"Среднее арифметическое: {sum / arr.Length}");
