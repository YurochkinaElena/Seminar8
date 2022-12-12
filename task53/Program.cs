// Задача 53: Задайте двумерный массив. напишите программу, которая поменяет местами первую и последнюю строку массива.

// 1 2 3
// 4 5 6 
// 7 8 9
// ---> 
// 7 8 9
// 4 5 6 
// 1 2 3  

var arr = FillMatrix(3, 4);
PrintMatrix(arr);
ChengeRows(arr);
Console.WriteLine();
PrintMatrix(arr);

void ChengeRows(int[,] matrix)
{
    int rowCount = matrix.GetLength(0) - 1; //rowCount - количество строк
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
       int temp = matrix[0, i];
       matrix[0, i] = matrix[rowCount, i];
       matrix[rowCount, i] = temp;
    }
}

int[,] FillMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 6);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
               for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}, ");
        }
        Console.WriteLine();
    }
}
