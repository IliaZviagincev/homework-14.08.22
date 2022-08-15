// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Console.Write("Введите количество строк по X : \t");
int array_X = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк по Y : \t");
int array_Y = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк по Z : \t");
int array_Z = int.Parse(Console.ReadLine());

int[,,] array = new int[array_X, array_Y, array_Z];
GetArray();
PrintArray(array);


void GetArray()
{
    int temp = 0;
    for (int i = 0; i < array_X; i++)
    {
        for (int j = 0; j < array_Y; j++)
        {
            int k = 0;
            while (k < array_Z)
            {
                temp = new Random().Next(10, 100);
                if (CheckRandomNumber(temp) == false)
                    array[i, j, k] = temp;
                {
                    k++;
                }
            }

        }
    }
}
bool CheckRandomNumber(int numb)
{
    for (int i = 0; i < array_X; i++)
    {
        for (int j = 0; j < array_Y; j++)
        {
            for (int k = 0; k < array_Z; k++)
            {
                if (numb == array[i, j, k])
                {
                    return true;
                }
            }
        }
    }


    return false;
}
void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}