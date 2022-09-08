// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Поиск натуральных чисел в промежутке от M до N: ");
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = RangeOfNumbers(m, n);
Console.WriteLine($"M = {m}; N = {n}. - > {result}");

string RangeOfNumbers(int m, int n)
{
    if (m > n)
    {
        return RangeOfNumbers(m, n + 1) + ", " + n;
    }
    else if (m < n)
    {
        return RangeOfNumbers(m + 1, n) + ", " + m;
    }
    {
        return Convert.ToString(n);
    }
}
