// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11.82 -> 10.9012 -> 12

Console.WriteLine(" введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
int rez = 0;
int count = Convert.ToString(num).Length;

for(int i = 1; i <=count; i ++)
{
    rez = rez + num % 10 ;// последняя цифра
    num /= 10; // новое значение 
}

Console.WriteLine(rez);