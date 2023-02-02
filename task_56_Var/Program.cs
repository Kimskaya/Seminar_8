/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с
наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int [,] GetRandomArray (int rowLength, int colLength, int start, int end)
{
    
    int [,] array = new int [rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
int [,] Array = GetRandomArray (5, 5, 0, 100);
void Printarray (int [,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]}    ");
        }
        Console.WriteLine("    ");
    }
} 
Printarray(Array);
Printarray ()


void Printarray (int [,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]}    ");
        }
        Console.WriteLine("    ");
    }
} 
Printarray(Array);

int GetMinSumRow (int [,] Array)
{  
    int rowSum= 0;
    int rowNumber = 0;
    int minSum = 
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
     rowSum = rowSum + Array [i,j];
    } 
    if (

    )

    rowNumber = j;
    Console.WriteLine($"Arithmetic average of the column is {rowNumber} "!);
    
}
}
GetMinSumRow(Array);
