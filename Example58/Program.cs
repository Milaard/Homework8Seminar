// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int rows = SetNumber("m");
int column = SetNumber("n");

int[,] firstMatrix = new int[rows, column];
int[,] secondMatrix = new int[rows, column];

firstMatrix = GetRandomMatrix(rows, column);
PrintMatrix1(firstMatrix);
System.Console.WriteLine();

secondMatrix = GetRandomMatrix(rows, column);
PrintMatrix2(secondMatrix);
System.Console.WriteLine();

int[,] resultMatrix = new int[rows, column];
IncreaseMatrix(firstMatrix, secondMatrix, resultMatrix);

int SetNumber(string name)
{
    string[] arr = name.Split(" ");
    System.Console.WriteLine($"Enter number {name}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetRandomMatrix(int rows, int column, int maxValue = 10, int minValue = 0)
{
    int[,] matrix = new int[rows, column];
    var random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix1(int[,] firstMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            System.Console.Write($"{firstMatrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
void PrintMatrix2(int[,] secondMatrix)
{
    for (int i = 0; i < secondMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            System.Console.Write($"{secondMatrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void IncreaseMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

PrintMatrix(resultMatrix);

void PrintMatrix(int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            System.Console.Write(resultMatrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
