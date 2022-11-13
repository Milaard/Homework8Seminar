// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

int rows = SetNumber("m");
int column = SetNumber("n");
int[,] matrix = new int[rows, column];
matrix = GetRandomMatrix(rows, column);
PrintMatrix(matrix);
System.Console.WriteLine();

ReturnNewMatrix(matrix);
System.Console.WriteLine();

int SetNumber(string name)
{
    string[] arr = name.Split(" ");
    System.Console.WriteLine($"Enter number {name}");
    int num = int.Parse(Console.ReadLine());
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
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
void ReturnNewMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] >= matrix[i, k+1]) continue;
                int temp = matrix[i, k+1];
                matrix[i, k+1] = matrix[i, k];
                matrix[i, k] = temp;
            }
       }
    }
}

PrintDescentingMatrix(matrix);
void PrintDescentingMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
