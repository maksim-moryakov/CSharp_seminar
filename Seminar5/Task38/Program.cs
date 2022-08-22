// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите длинну массива: ");
int sizeArray = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элементов массива: ");
int max = int.Parse(Console.ReadLine());

double[] CreateArray(int sizeArray, int min, int max)
{
    double[] array = new double[sizeArray];
    Random random = new Random();

    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = Math.Round(random.Next(min, max) + random.NextDouble(), 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
            Console.Write("Разница между максимальным и минимальным элементом массива [ ");
        if (i < array.Length - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i] + " ]");
    }
}

double MaxIndex(double[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[max])
            max = i;
    }
    return array[max];
}

double MinIndex(double[] array)
{
    int min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[min])
            min = i;
    }
    return array[min];
}

double[] array = CreateArray(sizeArray, min, max);
PrintArray(array);
double result = Math.Round(MaxIndex(array) - MinIndex(array), 2);
Console.WriteLine($" = {result} ");
