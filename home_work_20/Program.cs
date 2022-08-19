// Задача 50. Напишите программу, которая на вход принимает позиции элемента либо значение элемента в двумерном массиве, 
// и возвращает значение либо индекс этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет
// 4 -> такой элемент есть и его индекс 0, 1 (идеально было б найти все вхождения этого элемента)
// 2, 3 -> такой элемент есть и равен 4
// 5, 5 -> такой элемент отсутствует

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

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);

Console.Write("Введите число которое следует найти в данном массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
void SearchArray(int[,] array)
{
    int mass_i = 0;
    int mass_j = 0;
    bool z = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (num == array[i, j])
            {
                z = true;
                mass_i = i;
                mass_j = j;
            }

        }
        if (z) Console.WriteLine($"{num} под индексом {mass_i},{mass_j} пристутсвует в массиве");
        else Console.WriteLine("Данного числа нет в массиве");
    }

}

Console.Write("Введите индекс i, что бы найти число в данном массиве: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс j, что бы найти число в данном массиве: ");
int b = Convert.ToInt32(Console.ReadLine());
void SearchNum(int[,] array)
{
    int n = 0;
    bool z = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (a == i && b == j)
            {
                z = true;
                n = array[i, j];
            }

        }

    }
    if (z) Console.WriteLine($"Элемент под индексом {a} , {b} равен: {n} ");
    else Console.WriteLine("Такой элемент отсутствует!");

}

SearchArray(array);
SearchNum(array);
