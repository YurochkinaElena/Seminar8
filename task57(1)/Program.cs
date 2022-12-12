// 2 ВАРИАНТ // Задача 57. составить частотный словарь элементов двумерного массива.
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



var arr = FillMatrix(4, 4);
PrintMatrix(arr);
var res = ElementDicitionary(arr);
foreach(var el in res)
{
System.Console.WriteLine($"{el.Key} meet: {el.Value}");
}

Dictionary<int, int> ElementDicitionary(int[,] arr)
{
Dictionary<int, int> result = new Dictionary<int, int>();
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
if(result.TryGetValue(arr[i,j], out int count))
{
result[arr[i,j]] += 1;
}
else
{
result.Add(arr[i,j], 1);
}
}
}
return result;
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
