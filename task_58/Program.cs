// task 56. Program which finds multiplication of 2 arrays
//

int [,] GetFirstArray (int rowLength, int colLength, int start, int end)
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
int [,] firstArray = GetFirstArray (5, 5, 0, 10);

int [,] GetSecondArray (int rowLength, int colLength, int start, int end)
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
int [,] secondArray = GetSecondArray (5, 5, 0, 10);


int[,] resultArray = new int[5, 5]; 
void MultiplyArrays(int[,] firstArray, int[,] secondArray)
{

  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstArray.GetLength(1); k++)
      {
        sum = sum + firstArray[i,k] * secondArray[k,j];
      }
      resultArray[i,j] = sum;
    }
  }
}
MultiplyArrays(firstArray, secondArray);

void Printarray (int [,] firstArray)
{
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            Console.Write($"{firstArray[i, j]}    ");
        }
        Console.WriteLine("    ");
    }
} 
Printarray(firstArray);
Console.WriteLine();
Printarray(secondArray);
Console.WriteLine();
Printarray(resultArray);
  