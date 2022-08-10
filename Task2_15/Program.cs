// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
//6 -> да,7 -> да,1 -> нет

Console.WriteLine("Введите число от 1 до 7 : ");
int n = Convert.ToInt32(Console.ReadLine());

switch (n)
{
case 1:
    {
        Console.WriteLine(" Понедельник- нет - рабочий  ");
        break;
    }
case 2:
    {
        Console.WriteLine(" Вторник- нет - рабочий  ");
        break;
    }
case 3:
    {
        Console.WriteLine(" Среда - нет - рабочий  ");
        break;
    }
case 4:
    {
        Console.WriteLine(" Четверг - нет - рабочий  ");
        break;
    }
case 5:
    {
        Console.WriteLine(" Пятница - нет - рабочая  ");
        break;
    }
case 6:
    {
        Console.WriteLine(" СУББОТА- ДА - ВЫХОДНОЙ  ");
        break;
    }
case 7:
    {
        Console.WriteLine(" ВОСКРЕСЕНЬЕ - ДА  - ВЫХОДНОЙ  ");
        break;
    }
default:
    {
        Console.WriteLine(" Не верно введена цифра, нужно от 1 до 7 ");
        break;
    }


}