//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)



int [,,] GetRandomArray (int rowLength, int colLength, int depLength, int start, int end)
{
    
    int [,,] array = new int [rowLength, colLength, depLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            for (int r = 0; r < depLength; r++)
            {
              array[i, j, r] = new Random().Next(0, 10);  
            }
            
        }
    }
    return array;
}
int [,,] Array = GetRandomArray (2, 2, 2,0, 10);

void Printarray (int [,,] Array)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int r = 0; r < 2; r++)
             {
             Console.Write($"{Array[i, j, r]} has index [{i},{j},{r}]  ");
             }
              Console.WriteLine("    ");
       }
    } 
}
Printarray(Array);