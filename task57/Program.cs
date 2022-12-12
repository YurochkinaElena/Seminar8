// Задача 57. составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том,  сколько раз встречается элемент входных данных.
// {1, 9, 9, 0, 2, 8, 0, 9}
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раза
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

var matrix = FillMatrix(4, 4);
PrintMatrix(matrix);

int[] arrNums = new int[matrix.GetLength(0) * matrix.GetLength(1)];
int arrNumsTrueLenght = 0;

GetFrequencyDictionary(matrix);

PrintCount(matrix);

void PrintCount(int[,] arr)
{
    for (int i = 0; i < arrNumsTrueLenght; i++)
    {
        System.Console.WriteLine($"{arrNums[i]} встречается {GetCount(arr, arrNums[i])}");
    }
}

int GetCount(int[,] arr, int element)
{
    int count = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == element)
            {
                count++;
            }
        }
    }
    return count;
}

void GetFrequencyDictionary(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            CheckContain(matrix[i, j]);
        }
    }
}

void CheckContain(int element)
{
    for (int i = 0; i <= arrNumsTrueLenght; i++)
    {
        if (element == arrNums[i])
        {
            return;
        }

    }
    arrNums[arrNumsTrueLenght] = element;
    arrNumsTrueLenght++;
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
