// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите длинну массива: ");
int sizeArray = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элементов массива: ");
int max = int.Parse(Console.ReadLine());

int[] CreateArray(int sizeArray, int min, int max)
{
    int[] array = new int[sizeArray];
    Random random = new Random();

    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

int SumOddNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("Cумма элементов, стоящих на нечётных позициях в массиве [ ");
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + " ]");
    }
}

int[] array = CreateArray(sizeArray, min, max);
PrintArray(array);
int sum = SumOddNumbers(array);
Console.WriteLine($" = {sum}");
