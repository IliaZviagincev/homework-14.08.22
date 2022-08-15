// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

Console.Write("Введите количество строк первого массива:\t");
int row1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов первого массива:\t");
int column1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк второго массива:\t");
int row2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов второго массива:\t");
int column2 = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array1 = new int[row1, column1];
int[,] array2 = new int[row2, column2];

int[,] GetArray(int rows, int col)
{
    int[,] arr = new int[rows, col];
    for (int i = 0; i < rows; i++)
    {
        for (int k = 0; k < col; k++)
        {
            arr[i, k] = new Random().Next(1, 10);


        }

    }
    return arr;
}

void PrintArray(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            Console.Write($"{array1[i, k]}\t");

        }
        Console.Write($"\t\t\t");
        for (int k = 0; k < array2.GetLength(1); k++)
        {
            Console.Write($"{array2[i, k]}\t");

        }
        Console.WriteLine();
    }
    Console.WriteLine();

}
int[,] GetMatrixMult(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[arr1.GetLength(0), arr1.GetLength(1)];


    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int k = 0; k < result.GetLength(1); k++)
        {
            result[i, k] = arr1[i, k] * arr2[i, k];
            Console.Write($"{result[i, k]}\t");
        }
        Console.WriteLine();
    }

    return result;
}

array1 = GetArray(row1, column1);
array2 = GetArray(row2, column2);

if (row1 == row2 || column1 == column2)
{
    PrintArray(array1, array2);
    Console.WriteLine("Результат умножения матриц: ");
    int[,] result_array = GetMatrixMult(array1, array2);
}
else Console.WriteLine("Массивы не равны. Выполнение отклонено");

