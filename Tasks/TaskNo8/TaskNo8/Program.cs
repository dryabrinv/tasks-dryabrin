while (true)
{
    Console.WriteLine("Введите два числа:");
    double first = Convert.ToDouble(Console.ReadLine());
    double second = Convert.ToDouble(Console.ReadLine());

    if (first >= 0 && first <= 10 && second >= 0 && second <= 10)
    {
        Console.WriteLine($"{first} * {second} = {first * second}");
        break;
    }
    else
    {
        Console.WriteLine("Введенные числа недопустимые. Повторите ввод.");
    }
}
