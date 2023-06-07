// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int InputNumber()
{
    int num = new Random().Next(4, 4);
    return num;
}
void CraeteArray(int[,] arr)
{
    int num = 1, i = 0, j = 0, temp = 0, sizeRow = arr.GetLength(0), sizeColumn = arr.GetLength(1);
    while (num <= arr.GetLength(0) * arr.GetLength(1))
    {
        for (i = temp; i < sizeColumn; i++)
        {
            arr[j, i] = num++;
        }
        j = sizeColumn - 1;
        for (i = temp + 1; i < sizeRow; i++)
        {
            arr[i, j] = num++;
        }
        j = sizeRow - 1;
        for (i = sizeColumn - 2; i >= temp && temp != sizeRow - 1; i--)
        {
            arr[j, i] = num++;
        }
        j = temp;
        for (i = sizeRow - 2; i > temp && temp != sizeColumn - 1; i--)
        {
            arr[i, j] = num++;
        }
        sizeColumn--;
        sizeRow--;
        temp++;
        j = temp;
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
int row = InputNumber(), colums = InputNumber();
int[,] array = new int[row, colums];
CraeteArray(array);
PrintArray(array);