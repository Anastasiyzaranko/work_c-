//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное.
/*a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите  первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  второе  число: ");
int m = Convert.ToInt32(Console.ReadLine());
int max = n;
if (m > max)  max = m; 
if (n> max)  max = n;
Console.WriteLine(" максимальное число =  ");
Console.WriteLine( max );

 
