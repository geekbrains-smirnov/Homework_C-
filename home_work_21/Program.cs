// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);

        }

    }
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);



void Average(int[,] array)
{
    double result = 0;
    double result1 = 0;
    double result2 = 0;
    double result3 = 0;

    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0)
            {
                result += array[i, j];


            }
            if (j == 1)
            {
                result1 += array[i, j];


            }
            else if (j == 2)
            {
                result2 += array[i, j];


            }
            else if (j == 3)
            {
                result3 += array[i, j];


            }

        }

    }

    Console.WriteLine($"{result / m}, {result1 / m}, {result2 / m}, {result3 / m}");

}

Average(array);
