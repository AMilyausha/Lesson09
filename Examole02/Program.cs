// Задача 2**. Напишите программу, которая спирально заполнит 
// числами от 1 до 16 двумерный массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// Указание:
// При заполнении массива использовать циклы.
int n = 4;
int[,] array = new int[n, n];
void PrintArray(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.Write("] ");
        Console.Write($"\n");
    }
}
void FillArray(int[,] array)
{
    int num = 1;
    int i = 0;
    int j = 0;
    while (num <= n * n)
    {
        array[i, j] = num;
        if (i <= j + 1 && i + j < n - 1)
            ++j;
        else if (i < j && i + j >= n - 1)
            ++i;
        else if (i >= j && i + j > n - 1)
            --j;
        else
            --i;
        ++num;
    }
}

FillArray(array);
PrintArray(array);