// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int cube(int n)
{
    int count = 0;
    int result = 0;
    while(count<=n)
    {
    result= count*count*count;
    
    count++;
    Console.WriteLine(result);
    }
    
    
    return (result);
}

Console.WriteLine(cube(n));
