// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int FunctionAkk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return FunctionAkk(m - 1, 1);
    else return FunctionAkk(m - 1, FunctionAkk(m, n - 1));

}

Console.WriteLine();
Console.Write("A(m,n) = ");
Console.WriteLine(FunctionAkk(m, n));
