// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.GetUpperBound(1) + 1;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

int[,] array = FillArray(4, 4);

PrintArray(array);

Console.WriteLine("Введите номер строки:");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер колонки:");
int col = Convert.ToInt32(Console.ReadLine());

if (row - 1 < array.GetLength(0) && col - 1 < array.GetLength(1))
{
    Console.WriteLine($"Индекс заданого элемента: {array[row - 1, col - 1]}");
}
else
{
    Console.WriteLine("Такого элемента в массиве нет");
}
