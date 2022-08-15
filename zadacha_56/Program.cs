// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


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
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Console.Write($"{array[i, k]}\t");

        }
        Console.Write($"|Строка {i + 1}");
        Console.WriteLine();
    }
    Console.WriteLine();
}
string GetRow(int[,] array)
{
    int[] temp = new int[2];
    temp[0] = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int k = 0; k < array.GetLength(1); k++)
        {
            sum += array[i, k];

        }


        if (sum < temp[0] || temp[0] == 0)
        {
            temp[0] = sum;
            temp[1] = i + 1;
        }
    }

    return $"Строка с наименьшей суммой: {temp[1]}";
}

GetArray(row, column);
Console.WriteLine("Сгенерированный массив");
PrintArray(array);
Console.WriteLine(GetRow(array));

