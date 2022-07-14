// string[,] table = new string[2, 5];
// String.Empty


int[,] matrix = new int[3, 4];

void PrintArray(int[,] matx)
{
    for (int i = 0; i < matx.GetLength(0); i++)
    {
        for (int j = 0; j < matx.GetLength(1); j++)
        {
            Console.Write($"{matx[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matx)
{
    for (int i = 0; i < matx.GetLength(0); i++)
    {
        for (int j = 0; j < matx.GetLength(1); j++)
        {
            matx[i, j] = new Random().Next(1, 10);
        }
    }
}
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);