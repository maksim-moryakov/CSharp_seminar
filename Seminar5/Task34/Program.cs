// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите длинну массива: ");
int sizeArray = int.Parse(Console.ReadLine());

int[] FillArray(int sizeArray)
{
    int[] array = new int[sizeArray];
    Random random = new Random();

    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

int FindEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)

            count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
            Console.Write("В массиве [ ");
        if (i < array.Length - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i] + " ]");
    }
}

int[] array = FillArray(sizeArray);
PrintArray(array);
int evenNumber = FindEvenNumbers(array);
Console.WriteLine($" колличество чётных чисел = {evenNumber}");
