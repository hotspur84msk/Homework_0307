// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int InputNumber()
{
    int num = new Random().Next(4, 5);
    return num;
}
void CraeteArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void CheckLowestSum(int[,] arr)
{
    int sum = 0, min = 0, index = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = 0;
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                sum += arr[i, k];
            }
            if (sum < min || min == 0)
            {
                min = sum;
                index = i;
            }
        }
    }
    Console.WriteLine($"Строка {index + 1} имеет наименьшую сумму = {min}");
}

int row = InputNumber(), colums = InputNumber();
int[,] array = new int[row, colums];
CraeteArray(array);
PrintArray(array);
Console.WriteLine();
CheckLowestSum(array);