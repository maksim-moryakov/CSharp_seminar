// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> дa

string palindrome(string str)
{
    if (str[0] == str[4] && str[1] == str[3]);
    {
        string yes = "ДА";
        return yes;
    }
    string no = "НЕТ";
    return no;
}

Console.WriteLine("Введиет пятизначное число: ");
string? str = Console.ReadLine();
Console.WriteLine($"Введеное число полиндром: {palindrome(str)}");