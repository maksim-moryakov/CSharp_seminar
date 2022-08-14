// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
// Решение №1 Простое.
int cube = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= cube; i++)
{
    Console.Write(Math.Pow(i, 3) + " ");
}

Console.WriteLine();

// Решение №2 Через метод.
void Cube(int[] cube){
    for (int i = 0; i < cube.Length; i++)
    {
        cube[i] = Convert.ToInt32(Math.Pow(i, 3));
    }
}

void PrintArry(int[] coll){
  for (int i = 1; i < coll.Length; i++)
  {
    Console.Write(coll[i]+ " ");
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);