// найти максимальное число из 9, составление функции                !!!!!
/*int Max(int arg1, int arg2, int arg3)
{
    int rezult = arg1;
    if (arg2 > rezult) rezult = arg2; // ищет макс из 3     
    if (arg3 > rezult) rezult = arg3;
    return rezult;
}

int a1 = 15;
int b1 = 17;
int c1 = 32;
int a2 = 68;
int b2 = 96;
int c2 = 100;
int a3 = 678;
int b3 = 961;
int c3 = 10;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

int max = Max(max1, max2, max3);
Console.WriteLine(max);
*/


// задание с массивом                                                    !!!!
/*int Max(int arg1, int arg2, int arg3)
{
    int rezult = arg1;
    if (arg2 > rezult) rezult = arg2; // ищет макс из 3     
    if (arg3 > rezult) rezult = arg3;
    return rezult;
}
int [] arrey = {2, 17, 35, 54, 55, 75, 89, 63, 7 };
arrey [0]= 5; //  замена значения
Console.WriteLine(arrey[0]); // выводит это значение

int max = Max(
    Max(arrey[0],arrey[1],arrey[2]),
    Max(arrey[3],arrey[4],arrey [5]),
    Max(arrey[6],arrey[7],arrey[8])
);    
Console.WriteLine(max);
*/

/*Имеется одномерный массив array из n элементов, требуется                 !!!!!
найти элемент массива, равный find
1. Установить счетчик index в позицию 0
2. Если array [index] = find, алгоритм завершил работу
успешно.
3. Увеличить index на 1
4. Если index < n, то перейти к шагу 2. В противном случае
алгоритм завершил работу безуспешно.
*/

/*
int[] array = {5,  56,  8, 25, 86, 94, 36, 5 ,98, 1, 10};
int n = array.Length; // возвращает длинну массива(arrey)Length
int find = 98;
int index = 0;
while (index < n)
{
    if (array[index]== find) // совпадает или равен
    {
        Console.WriteLine(index);
        break;
    }
    index ++; 
} 
*/

//                                                         !!!!!!!!! ну очкнь много 
/*void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index]= new Random().Next(1,10);
        index ++;
    }
}
void PrintArray(int[]col)  // печатает массив , аргументы не повторяют название
{
    int count=col.Length;
    int position =0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int IndexOf(int []collection,int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while ( index< count)
    {
        if(collection[index]== find )
        {
            position= index;
            break;
        }
        index ++;
    } 
    return position;
} 

int[]array=new int[10];
FillArray(array); /// метод заполняет массив
PrintArray(array); //  распечатывае наш массив

Console.WriteLine();
int pos= IndexOf(array, 93);
Console.WriteLine(pos);
*/
