Console.WriteLine("Введите сумму вклада:");
double amount = Convert.ToDouble(Console.ReadLine());

if (amount < 100.0)
{
    amount += amount * 0.05;
}
else if (amount >= 100.0 && amount <= 200.0)
{
    amount += amount * 0.07;
}
else
{
    amount += amount * 0.1;
}

Console.WriteLine($"Сумма вклада с процентами: {amount}");
