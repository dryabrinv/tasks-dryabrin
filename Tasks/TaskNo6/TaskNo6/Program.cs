Console.WriteLine("Введите начальную сумму вклада:");
decimal sum = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Введите количество месяцев:");
int months = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < months; i++)
{
    sum += sum * 0.07m;
}

Console.WriteLine($"Конечная сумма вклада: {sum}");
