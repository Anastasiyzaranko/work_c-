// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих 
//на нечётных позициях.//[3, 7, 23, 12] -> 19   [-4, -6, 89, 6] -> 0

void FillAray(int []arr)
{
    for (int i=0; i<arr.Length;i++)
    {
        arr[i]= new Random().Next(-10,20);
    }
}
void PrintArr(int[]arr)
{
    for (int i=0; i<arr.Length;i++)
    {
        Console.Write($"{arr[i]} " );
    }
}
int [] array = new int [6];
FillAray(array);
PrintArr(array);
Console.WriteLine();
int sum = 0;
for(int i = 1;i<array.Length;i=i+2)
{
    if (array[i] != 0 )
    {
        sum = sum + array[i];
    }
}    
Console.WriteLine($"сумму элементов, стоящих на нечётных позициях равна  {sum} ");

