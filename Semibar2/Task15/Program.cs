// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Enter the number of the day of the week: ");
int numberDay = Convert.ToInt32(Console.ReadLine());

void CheckNumberDay(int numberDay)
{
    if (numberDay >= 1 && numberDay < 6)
    {
        Console.WriteLine("Working day");
    }
    else if (numberDay == 6 || numberDay == 7)
    {
        Console.WriteLine("Weekend");
    }
    else
        Console.WriteLine("This day of the week does not exist");
}

CheckNumberDay(numberDay);
