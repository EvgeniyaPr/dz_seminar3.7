// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 11);
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
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[] averageCols(int[,] matr)
{
    double[] averCols = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            result += matr[i, j];
            averCols[j] = Math.Round(result / matr.GetLength(0), 1);
        }
    }
    return averCols;
}

void PrintAverCols(double[] averArray)
{
    System.Console.Write(string.Join(", ", averArray));
}

int rows = ReadInt("Введите колчество строк матрицы: ");
int cols = ReadInt("Введите колчество столбцов матрицы: ");
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
System.Console.WriteLine();
averageCols(myMatrix);
PrintAverCols(averageCols(myMatrix));
System.Console.WriteLine($"Среднее арифметическое каждого столбца: {averageCols(myMatrix)}");