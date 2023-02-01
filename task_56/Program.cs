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
            array[i, j] = new Random().Next(0, 100);
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


int FindMinSumRow (int [,] Array)
    {
      int row = 0;
      int minSum = 0;
      for (int i = 0; i < Array.GetLength(1); i++)
        {
            minSum = minSum + Array[0,i];
        }
      for (int i = 1; i < Array.GetLength(0); i++)
        {
            int sumNum = 0;
            for (int j = 0; j < Array.GetLength(1); j++)
              {
                 sumNum = sumNum + Array[i,j];
              }
            if (minSum > sumNum)
               {
                  minSum = sumNum;
                  row = i;
               }
        }
        return row;
    }
int result = FindMinSumRow(Array);
Console.WriteLine();  
Console.WriteLine($"The minimum sum of the elements is in the row {result}");