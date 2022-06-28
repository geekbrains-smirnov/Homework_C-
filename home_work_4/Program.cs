// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
int even = 1;
int num = 0;

while (count <= N)
{
    if (num == even % 2)
    {
        num = 0;
        Console.WriteLine($"Четные числа: {even}");
    }

    count++;
    even++;
}

