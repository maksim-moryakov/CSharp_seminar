// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int col = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[row, col];

for (int i = 0; i < row; i++)
{
    for (int  j = 0; j < col; j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine("");
}

Console.WriteLine();
Console.Write($"Cреднее арифметическое каждого столбца: ");
for (int i = 0; i < col; i++)
{
  double average = 0;
  for (int j = 0; j < row; j++)
  {
    average += array[j, i];
  }
  average = average / row;
  Console.Write($"{average} ");
}