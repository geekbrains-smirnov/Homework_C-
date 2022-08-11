// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


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
int chet(int n)
{
    int[] array = new int[n];
    int count = 0;
    for(int i = 0; i<n; i++)
    {
        array[i] = new Random().Next(100,1000);
        if(array[i]%2==0) count++;
        

    }
    PrintArray(array);
    Console.Write("Количество четных элементов в данном массиве: ");


    return count;
}
Console.WriteLine(chet(n));


