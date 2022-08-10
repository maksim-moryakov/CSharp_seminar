// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Enter a three-digit number: ");
int number = int.Parse(Console.ReadLine());
string numberStr = number.ToString();

Console.WriteLine($"The second number - {numberStr[1]}");

