Console.WriteLine("Введите два числа:");

int first = Convert.ToInt32(Console.ReadLine());
int second = Convert.ToInt32(Console.ReadLine());

if (first > second)
{
    Console.WriteLine($"Первое число ({first}) больше второго ({second})");
}
else if (first < second)
{
    Console.WriteLine($"Первое число ({first}) меньше второго ({second})");
}
else
{
    Console.WriteLine("Числа равны");
}
