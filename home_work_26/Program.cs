// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Number(int m, int n)
{
    if (m<=n) return Number(m, n-1) + n;
    else return 0; 
}

Console.WriteLine();
Console.Write("Сумма натуральных элементов в промежутке от m до n равна: ");
Console.WriteLine(Number(m,n));
