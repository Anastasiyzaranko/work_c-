// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 
//3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84,       A (7,-5, 0); B (1,-1,9) -> 11.53



Console.WriteLine(" Введите число х1 :");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите число х2 :");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите число х3 :");
int x3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Введите число y1 :");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите число y2 :");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите число y3 :");
int y3 = Convert.ToInt32(Console.ReadLine());

double xy = Math.Sqrt(Math.Pow(y1-x1,2)+Math.Pow(y2-x2,2)+Math.Pow(y3-x3,2));

Console.WriteLine( xy); 