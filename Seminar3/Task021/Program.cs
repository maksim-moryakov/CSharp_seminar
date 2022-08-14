// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double CalcDistance(int ax, int ay, int az, int bx, int by, int bz)
{
    return Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
}

Console.Clear();
Console.WriteLine("Ведите координаты точки A, в 3D пространстве: ");
int ax = int.Parse(Console.ReadLine());
int ay = int.Parse(Console.ReadLine());
int az = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите координаты точки B, в 3D пространстве: ");
int bx = int.Parse(Console.ReadLine());
int by = int.Parse(Console.ReadLine());
int bz = int.Parse(Console.ReadLine());

Console.WriteLine($"Растояние между точкой A и B равно {Math.Round(CalcDistance(ax, ay, az, bx, by, bz), 2)}"); 