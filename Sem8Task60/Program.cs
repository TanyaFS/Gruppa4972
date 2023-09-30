// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Заполняем трехмерный массив из двухзначных неповторяющихся чисел
int[,,] Fill3DArray(int rows, int columns, int depth)
{
    System.Random rnd = new System.Random();
    int[,,] array = new int[depth, rows, columns];
    // Начальное значение, первое двузначное число
    int value = 10;
    for (int d = 0; d < depth; d++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                // Помещаем значение в массив и увеличиваем его для следующего элемента
                array[d, i, j] = value;
                value++;
                
                // Если достигли 100, переходим обратно к 10
                if (value == 100)
                {
                    value = 10;
                }
            }
        }
    }

    return array;
}

// Печатаем массив с индексами каждого элемента
void Print3DArray(int[,,] matrix)
{
    for (int d = 0; d < matrix.GetLength(0); d++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(2); j++)
            {
                Console.Write($"{matrix[d, i, j]}({d},{i},{j}) ");
            }

            Console.WriteLine();
        }
    }
}

int[,,] array3D = Fill3DArray(2, 2, 2); 
Print3DArray(array3D);