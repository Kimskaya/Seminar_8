//task 56: Create a rectangular 2-dimension array
// Program, which finds the row with the minimum sum of elements 
// 1 4 7 2
// 5 9 2 3
//8 4 2 4
//5 2 6 7
// the first row 

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
int [,] Array = GetRandomArray (5, 5, 0, 10);


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
      for (int i = 0; i < Array.GetLength(0); i++)
        {
            minSum = minSum + Array[0,i];
        }
      for (int i = 1; i < Array.GetLength(0); i++)
        {
            int tempSum = 0;
            for (int j = 0; j < Array.GetLength(1); j++)
              {
                 tempSum = tempSum + Array[i,j];
              }
            if (minSum > tempSum)
               {
                  minSum = tempSum;
                  row = i;
               }
        }
        return row;
    }
    int minRow = FindMinSumRow(Array);

    int FindMinSum (int [,] Array)
    {
      int minSum = 0;
      for (int i = 0; i < Array.GetLength(0); i++)
        {
            minSum = minSum + Array[0,i];
        }
      for (int i = 1; i < Array.GetLength(0); i++)
        {
            int tempSum = 0;
            for (int j = 0; j < Array.GetLength(1); j++)
              {
                 tempSum = tempSum + Array[i,j];
              }
            if (minSum > tempSum)
               {
                  minSum = tempSum;
               }
        }
        return minSum;
    }
int minSum = FindMinSum(Array);
Console.WriteLine();  
Console.WriteLine($"The minimum sum of the elements equals {minSum} and is in the row {minRow+1}");