//Задача 62. Заполните спирально массив 4 на 4.

Console.Write($"Задайте количество строк массива: \t");
int array_X = int.Parse(Console.ReadLine());
Console.Write($"Задайте количество столбцов массива: \t");
int array_Y = int.Parse(Console.ReadLine());
int[,] array = new int[array_X, array_Y];

SpiralArray(0, 0);
PrintArray(array);

void SpiralArray(int row, int col)
{
    array[0, 0] = 1;
    int incr = 2;
    while (row >= 0 && col >= 0 && row < array_X && col < array_Y)
    {
        if (col + 1 < array_Y && array[row, col + 1] == 0)
        {
            array[row, col + 1] = incr;
            col++;
            incr++;

        }
        else if (row + 1 < array_X && array[row + 1, col] == 0)
        {
            array[row + 1, col] = incr;
            row++;
            incr++;
        }
        else if (col - 1 >= 0 && array[row, col - 1] == 0)
        {
            array[row, col - 1] = incr;
            col--;
            incr++;
        }
        else if (row - 1 >= 0 && array[row - 1, col] == 0)
        {
            while (row - 1 >= 0 && array[row - 1, col] == 0)
            {
                array[row - 1, col] = incr;
                row--;
                incr++;
            }
        }
        else break;
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < array_X; i++)
    {
        for (int k = 0; k < array_Y; k++)
        {
            Console.Write($"{array[i, k]}\t");
        }
        Console.WriteLine();
    }
}
