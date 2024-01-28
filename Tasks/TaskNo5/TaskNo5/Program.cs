Console.WriteLine("Введите номер операции: \n1. Сложение \n2. Вычитание \n3. Умножение");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1:
        Console.WriteLine($"Выбрана операцию сложения");
        break;

    case 2:
        Console.WriteLine($"Выбрана операцию вычитания");
        break;

    case 3:
        Console.WriteLine($"Выбрана операцию умножения");
        break;

    default:
        Console.WriteLine("Операция неопределена");
        break;
}
