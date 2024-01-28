string[] strings = ["Python", "C++", "Ruby", "Rust", "C#", "C", "Java", "JavaScript", "Kotlin"];

Console.WriteLine("Введите строку (язык):");
string? input = Console.ReadLine();

if (strings.Contains(input))
{
    Console.WriteLine("Строка найдена!");
}
else
{
    Console.WriteLine("Строка не найден!");
}
