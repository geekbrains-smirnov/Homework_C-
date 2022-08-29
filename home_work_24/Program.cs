// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// и

// 1 5 8 5

// 4 9 4 2

// 7 2 2 6

// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10

// 20 81 8 6

// 56 8 4 24

// 10 6 24 49

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



Console.Write("Задайте количество строк первого массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов первого массива: ");
int n = Convert.ToInt32(Console.ReadLine());
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

Console.Write("Задайте количество строк второго массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов второго массива: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] array2 = new int[a, b];
void FillArray2(int[,] matr2)
{
    for (int k = 0; k < a; k++)
    {
        for (int f = 0; f < b; f++)
        {
            matr2[k, f] = new Random().Next(1, 10);

        }

    }
}



FillArray(array);
FillArray2(array2);
Console.WriteLine("Матрица первого массива: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Матрица второго массива: ");
PrintArray(array2);

int [,] result = new int [m,b];
void Proizvedeniye(int [,] array, int [,] array2 , int [,] result)
{
    int sum = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                sum = array[i,j] *array2[i,j];
            }
            result[i,j] = sum;
        }
    }
    
    
}

Console.WriteLine();
Proizvedeniye(array, array2, result);
Console.WriteLine("Произведение двух матриц: ");
PrintArray(result);

        

