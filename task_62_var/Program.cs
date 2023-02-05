// task_62 . Fill in array 4 by 4 spirally
// 1   2  3 4
// 12 13 14 5
// 11 16 15 6
// 10  9 8  7
int[,] array = new int[4,4];

int element = 1;
int i = 0;
int j = 0;
array[i, j] = element;
while (element <= array.GetLength(0) * array.GetLength(1))
{
  int rowOrColLength = i+j;
  element++;
  if (i <=j+1 && rowOrColLength < array.GetLength(0) - 1)
  {
    j++;
    array[i, j] = element;
  }
  else if (i < j && rowOrColLength >= array.GetLength(0) - 1)
  {
    i++;
    array[i, j] = element;
  }
  else if (i >= j && rowOrColLength > array.GetLength(0) - 1)
   {
    j--;
    array[i, j] = element;
   }
  else
  {
    i--;
    array[i, j] = element;
  }
}

PrintArray(array);

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"   {array[i,j]}      ");
    }
    Console.WriteLine();
  }
}
