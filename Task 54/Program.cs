// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < matrix.GetLength(0); i++) // rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //cols
        {
            matrix[i, j] = rand.Next(0, 21);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++) // rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //cols
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

}

int[,] SortRowDescending(int[,] matrix)    //Функция сортировки по убыванию элементов строки матрицы
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int minPosition = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[i, minPosition]) minPosition = k;
            }
            int tmp = matrix[i, j];
            matrix[i, j] = matrix[i, minPosition];
            matrix[i, minPosition] = tmp;
        }

    }
    return matrix;
}

int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов  матрицы: ");
System.Console.WriteLine();
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);

System.Console.WriteLine();
int[,] rowSort = SortRowDescending(myMatrix);
PrintMatrix(rowSort);