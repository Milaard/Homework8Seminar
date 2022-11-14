// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = SetNumber("m");
int column = SetNumber("n>m");
int[,] matrix = new int[rows, column];
matrix = GetRandomMatrix(rows, column);
PrintMatrix(matrix);
System.Console.WriteLine();
NumberMinRowSum(matrix);

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

void NumberMinRowSum(int[,] matrix)
{
    int minRowSum = 0;
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
        }
        System.Console.WriteLine($"сумма строки   {i + 1} равна {sumRow} ");

        if (i == 0)
        {
            minRowSum = sumRow;
        }
        else if (sumRow < minRowSum)
        {
            minRowSum = sumRow;
            index = i;
        }
    }
    System.Console.Write($"Строка с минимальной суммой равна {index + 1}");
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

