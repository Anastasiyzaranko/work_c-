// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.//[345, 897, 568, 234] -> 2

void FillAray(int [] arr)// ЗАПОЛНЯЕМ МАССИВ
{
    int length = arr.Length;
    for(int i = 0;i<length;i++)
    {
        arr[i]=new Random().Next(100,1000);
    }
}
void PrintArr(int [] arr)// распечатали массив
{
    for(int i = 0;i<arr.Length;i++)
    {
        Console.WriteLine($"{arr[i] } ");
    }
}
int [] array = new int[4];
FillAray(array);
PrintArr(array);

int sum = 0;
for(int i = 0;i<array.Length;i++)
{
    if ( array[i] % 2 == 0)
    {
        sum++;
    }
    
}    
Console.WriteLine($"количество четных чисел "+ sum);
