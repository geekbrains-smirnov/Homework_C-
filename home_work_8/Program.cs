// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите проверочное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string result(int num)
{
   int num1 = (num / 1000) + 9;
   int num2 = num % 100;
    if (num2 == num1) return ("Проверочное число является палиндромом");
    else return ("Проверочное число не является палиндромом");
}

Console.WriteLine(result(num));


