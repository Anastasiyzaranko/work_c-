// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2.      1, -7, 567, 89, 223-> 3
//Console.WriteLine(" Введите число a:");
//int a = Convert.ToInt32(Console.ReadLine());


static void FillAray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(-50, 50);
    }
    
}
static void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int[] array = new int[5];

FillAray(array);
PrintArr(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine();
 
Console.WriteLine($"Кол-во элементов > 0:   {count}");









