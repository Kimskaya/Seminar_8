//task 54: Create 2-dimension array. 
//Programm  arranges elements of the array in order of descending 
// example
//1 4 7 2
//5 9 2 3
//8 4 2 4
//We get 
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

void ArrangeElementsInRows(int[,] dimensArray)
{
  for (int i = 0; i < Array.GetLength(0); i++)
  {
    for (int j = 0; j < Array.GetLength(1); j++)
    {
      for (int k = 0; k < Array.GetLength(1) - 1; k++)
      {
        if (Array[i, k] < Array[i, k + 1])
        {
          int temp = Array[i, k + 1];
          Array[i, k + 1] = Array[i, k];
          Array[i, k] = temp;
        }
      }
    }
  }
}


Console.WriteLine();
ArrangeElementsInRows(Array);
Printarray(Array);  

