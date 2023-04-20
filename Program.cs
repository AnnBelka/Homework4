// Задача 19 (не решила)
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int number1 = Math.Abs(num);
int res = number1;
res = 0;

if (res != number1)
{
    Console.WriteLine($"{number1} -> нет");
}
else if (res == number1)
{
    Console.WriteLine($"{number1} -> да");
}



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// √((x2-x1) ^ 2) + (y2-y1) ^ 2 + (z2-z1) ^ 2

Console.Write("Введите x 1й точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y 1й точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z 1й точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x 2й точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y 2й точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z 2й точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2)),2));



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write ("Введите число N: ");
int N = Convert.ToInt32 (Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    Console.WriteLine ($"{i} -> {Math.Pow(i,3)}");
}
