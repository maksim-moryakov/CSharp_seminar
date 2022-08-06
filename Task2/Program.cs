// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите два числа, чтобы узнать какое из двух чисел больше");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Первое введенное число больше второго: " + a + " - max; " + b + " - min.");
}
else
{
    Console.WriteLine("Второе введенное число больше первого: " + b + " - max; " + a + " - min.");
}
