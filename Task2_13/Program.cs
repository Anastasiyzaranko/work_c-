// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5,78 -> третьей цифры нет,32679 -> 6

Console.WriteLine(" Ведите  число : ");
int b = Convert.ToInt32(Console.ReadLine());

if ( b >= 10000 && b <= 99999)
{
    Console.WriteLine((b / 100) % 10  );
}
if ( b >= 1000 && b <= 9999)
{
    Console.WriteLine((b / 10) % 10  );
}
if ( b >= 100 && b <= 999)
{
    Console.WriteLine(b  % 10  );
}
if ( b <99 )
{
    Console.WriteLine(" Третьей цифры нет" );
    
}