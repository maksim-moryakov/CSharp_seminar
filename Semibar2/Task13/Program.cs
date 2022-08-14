// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Enter number: ");
string? strNumber = Console.ReadLine();
if (strNumber.Length < 3)
{
    Console.WriteLine("There is no third number");
}
else
{
    Console.WriteLine($"The third digit of a given number -> {strNumber[2]}");
}
