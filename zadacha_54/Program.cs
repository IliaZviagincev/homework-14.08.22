// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.


Console.Write("Введите количество строк массива:\t");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива:\t");
int column = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[row, column];

void GetArray(int rows, int col)
{
    for (int i = 0; i < rows; i++)
    {
        for (int k = 0; k < col; k++)
        {
            array[i, k] = new Random().Next(1, 10);

        }

    }
}
void GetSort(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < column; k++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
                if (array[i, j] < array[i, j + 1])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }

        }

    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Console.Write($"{array[i, k]}\t");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
GetArray(row, column);
Console.WriteLine("Сгенерированный массив");
PrintArray(array);
GetSort(array);
Console.WriteLine("Массив после сортировки");
PrintArray(array);
