// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

// Заполняем двумерный массив
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rnd.Next(downBorder, topBorder);
        }
    }
    return array2D;
}

// Печатаем массив
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
{
    int rowsA = matrixA.GetLength(0);
    int columnsA = matrixA.GetLength(1);
    int rowsB = matrixB.GetLength(0);
    int columnsB = matrixB.GetLength(1);

    int[,] resultMatrix = new int[rowsA, columnsB];

    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < columnsB; j++)
        {
            int sum = 0;
            for (int k = 0; k < columnsA; k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }

    return resultMatrix;
}


int[,] arrA = Fill2DArray(3,3,10,0);
int[,] arrB = Fill2DArray(3,3,10,0);
Print2DArray(arrA);
Console.WriteLine("---------------------");
Print2DArray(arrB);
Console.WriteLine("---------------------");
int[,] resultMatrix = MultiplyMatrices(arrA, arrB);
Print2DArray(resultMatrix);
