//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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


 int [] arrangedArray = new int [Array.GetLength(0)]; 
 int temp =0;
 
    for (int i = 0; i < Array.GetLength(0)-1; i++)
    {
        for (int j = 0; j < Array.GetLength(1)-1; j++)
        {
         if (Array [i,j] > Array [i+1, j])
         {
          
         temp = Array [i,j];
         Array [i, j] = Array [i+1, j];
         Array[i+1, j] = temp;
         i++;
         arrangedArray [i] = Array [i,j];
         }
        }
    }

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{arrangedArray[i]}    ");
        }
        Console.WriteLine("    ");
    }
/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
void SetAnArray( int[,] dimensArray)
{
    for (int i = 0; i < dimensArray.GetLength(0); i++)
    {
        for (int j = 0; j < dimensArray.GetLength(1); j++)
        {
            dimensArray[i,j] = new Random().Next(1,10);;
        }
    }
}
void printDemArr(int[,] dimensArray)
{
    for (int i = 0; i < dimensArray.GetLength(0); i++)
    {
        for (int j = 0; j < dimensArray.GetLength(1); j++)
        {
            Console.Write($"{dimensArray[i, j]} ");
        }
        Console.WriteLine("");
    }
}
void OrderOfDimensArrayRow(int[,] dimensArray)
{
  for (int i = 0; i < dimensArray.GetLength(0); i++)
  {
    for (int j = 0; j < dimensArray.GetLength(1); j++)
    {
      for (int k = 0; k < dimensArray.GetLength(1) - 1; k++)
      {
        if (dimensArray[i, k] < dimensArray[i, k + 1])
        {
          int tmp = dimensArray[i, k + 1];
          dimensArray[i, k + 1] = dimensArray[i, k];
          dimensArray[i, k] = tmp;
        }
      }
    }
  }
}

int[,] dimensArray = new int [3,4];
SetAnArray(dimensArray);
printDemArr(dimensArray);
Console.WriteLine();
OrderOfDimensArrayRow(dimensArray);
printDemArr(dimensArray);  