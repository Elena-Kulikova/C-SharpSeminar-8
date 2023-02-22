// Задача 62: Заполните спирально массив 4 на 4.

//  Функция заполнения массива по спирали начиная с 1
void FillMatrixSpiral(int[,] matrix, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { matrix[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) matrix[i++, j] = value++;
        for (k = 0; k < n - 1; k++) matrix[i, j--] = value++;
        for (k = 0; k < n - 1; k++) matrix[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

// Функция вывода на печать двумерного массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write("0" + matrix[i, j]);
                Console.Write("\t");
            }
            else Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int len = 4;
int[,] myMatrix = new int[len, len];
FillMatrixSpiral(myMatrix, len);
PrintMatrix(myMatrix);