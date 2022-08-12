// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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
int diff(int n)
{
    int[] array = new int[n];
    int result = 0;
    for (int i = 0; i < n; i++)
        {
            array[i] = new Random().Next(0,100);
            
        }

                int max = array[0];
                int min = array[0];
                for (int i = 1; i < n; i++)
                    {
                        if(array[i] > max) max = array[i];
                        else if (array[i] < min) min = array[i];
                    }
                    result = max - min;
                    PrintArray(array);
                    Console.WriteLine($"Максимальный элеммент массива: {max}"); 
                    Console.WriteLine($"Минимальный элеммент массива: {min}");
                    Console.Write("Разница между максимальным и минмальным элементами массива равна: ");

    return result;
        
}
        

Console.WriteLine(diff(n));       
        
        

        



