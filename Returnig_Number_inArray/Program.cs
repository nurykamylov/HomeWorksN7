/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4
*/
Console.Write("type the number!: " );
int a = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(3,4);
PrintArray(array);
Console.Write("position of element: ");
Console.WriteLine(SearchingElement( array, a));


int [,] GetArray(int row, int col)
{
    int[,] array = new int[row,col];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(10);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

Tuple<int, int>  SearchingElement(int[,] arr, int a)
{
    int row = -1;
    int col = -1;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          if (array[i,j] == a)
          {
            row = i;
            col = j;
            break;
          }
        }
    }
    
    if ( row == -1 || col == -1) Console.WriteLine("there is not number like that");
   
    return Tuple.Create( row +1, col +1);
}