// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


void FillAray(int[] arr)// ЗАПОЛНЯЕМ МАССИВ
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
}
void PrintArr(int[] arr)// распечатали массив
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{arr[i]} ");
    }
}

int[] array = new int[6];
FillAray(array);
PrintArr(array);

int min = 99;
int max = 0;
int rez = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];

    if (array[i] < min) min = array[i];

    rez = max - min;
}
Console.WriteLine($" максимальное значение {max}");

Console.WriteLine($" минимальное значение {min}");


Console.WriteLine($" разница между максимальным  и минимальным равна {max}-{min}= {rez}");