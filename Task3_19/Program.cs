﻿// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет,12821 -> да,23432 -> да


Console.WriteLine("введите номер ");
int n = Convert.ToInt32(Console.ReadLine());

if ((n / 10000) % 10 == n % 10 && (n / 1000) % 10 == (n / 10) % 10)
{
    Console.WriteLine(" число является палиндромом ");
}

else
{
    Console.WriteLine("число не является палиндромом ");
}





