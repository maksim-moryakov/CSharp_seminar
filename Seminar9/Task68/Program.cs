﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Write("Введи M: ");
int m = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи N: ");
int n = Convert.ToInt16(Console.ReadLine());
Ackerman(n, m);
            
static int Ackerman(int n, int m)
{
    if (n == 0) 
    {
        return m + 1;
    }    
    if (n != 0 && m == 0) 
    {
        return Ackerman(n - 1, 1);
    }    
    if (n > 0 && m > 0) 
    {
        return Ackerman(n - 1, Ackerman(n, m - 1));
    }    
    return Ackerman(n,m);
}
Console.WriteLine(Ackerman(n,m));