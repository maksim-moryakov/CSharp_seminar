﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int m = InputNumbers("Введите колличество строк массива: ");
int n = InputNumbers("Введите колличество столбцов массива: ");
int range = InputNumbers("Введите диапазон чиссел в массиве: от 1 до ");

int[,] array = new int[m, n];
FillArray(array);

Console.WriteLine($"\nОтсортированный массив: ");
ArrangeArray(array);

void ArrangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}