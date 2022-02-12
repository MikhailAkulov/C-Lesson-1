// Массив строк с числами

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // что равнозначно for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) // что равнозначно for (int j = 0; j < 4; j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // [1; 10)
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);