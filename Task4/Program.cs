/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите три числа, чтобы узнать какое из трех чисел максимальное");
int a = int.Parse(Console.ReadLine()); 
int b = int.Parse(Console.ReadLine()); 
int c = int.Parse(Console.ReadLine());

if (a > b && a > c) {Console.WriteLine(a + " максимальное число");}
else if (b > a && b > c) {Console.WriteLine(b + " максимальное число");}
else {Console.WriteLine(c + " максимальное число");}

