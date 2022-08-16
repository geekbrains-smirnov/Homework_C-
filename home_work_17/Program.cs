// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, -567, 89, 223-> 3

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
int Positive(int n)
{
    int[] array = new int[n];
    int count = 0;

    for(int i = 0; i<n; i++)
    {
        array[i] = new Random().Next(-200, 300);
        
    }
    PrintArray(array);
    for(int i = 0; i<n; i++)
    {
        
        if(array[i]>0) count++;
        
    }
    Console.Write("Количество чисел которые больше 0: ");
    return count;
}    
Console.WriteLine(Positive(n));

