// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}




int m = 4;

int n = 4;
int[,] array = new int[m, n];
void FillArray(int[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr[i, j] = new Random().Next(1, 10);

        }

    }
}

FillArray(array);
PrintArray(array);

void MinString(int[,] array)
{
    int result = 0;
    int result1 = 0;
    int result2 = 0;
    int result3 = 0;


    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0) result += array[i, j];
            else if (i == 1) result1 += array[i, j];
            else if (i == 2) result2 += array[i, j];
            else if (i == 3) result3 += array[i, j];
        }

    }
    int min = result;
    int string_min = 1;
    if (result1 < min)
    {
        min = result1;
        string_min = 2;
    }
    else if (result2 < min)
    {
        min = result2;
        string_min = 3;
    }
    else if (result3 < min)
    {
        min = result3;
        string_min = 4;
    }

    Console.WriteLine($"Строка с наименьшей суммой элементов: строка {string_min}");
}


MinString(array);

