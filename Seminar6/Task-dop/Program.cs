// Доп. задча: Задайте двумерный массив со случайными числами от -10 до 10. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.WriteLine("Введите колличество строк и колличество столбцов");
int line = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());
int [ , ] array = new int [line , column];

int[,] FillArray(int [,] array)           
{   
    for(int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i,j] = new Random().Next(-10, 10);
            Console.Write("["+array[i, j]+ "] ");
        }
        Console.WriteLine();
    }
    return array;
}

void SumMainDiagonal (int [,] array)
{
    string str ="";
    int sum = 0;
    int length = 0;
    if (line > column ) {length = column;}
    else length = line;
    for (int i = 0; i < length; i++)
    {
        sum += array[i,i];
        str = str + ", " + array[i,i];
    }
    Console.WriteLine("Элементы главной диагонали"+ str);
    Console.WriteLine("Сумма элементов главной диагонали ="+ sum);
}

SumMainDiagonal(FillArray(array));