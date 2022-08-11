// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void PrintArray(int[] array)
    {
        int count = array.Length;

        for(int i = 0; i < count; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();

    }

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int ArraySum(int n)
{
    int[] array = new int[n];
    int result = 0;
    for (int i = 1; i<n; i++)
        {
            array[i] = new Random().Next(1,100);
            if (i%2!=0) result = result+ array[i];

        }
        PrintArray(array);
        Console.Write("Сумма элементов стоящих на нечетных позициях данного массива: ");
        return result;
}

Console.WriteLine(ArraySum(n));