// task_62 . Fill in array 4 by 4 spirally
// 1   2  3 4
// 12 13 14 5
// 11 16 15 6
// 10  9 8  7

int[,] array = new int[4,4];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= array.GetLength(0) * 4)
{
  array[i, j] = temp;
  temp++;
  if (i <= j && i<4 )
    j++;
  else if (i < j&& <4 )
    i++;
  else if (i >= j)
    j--;
  else
    i--;
}
PrintArray(array);

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {

      Console.Write($" {array[i,j]} ");
    }
    Console.WriteLine();
  }
}
