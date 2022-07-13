// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6




Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;


if (num > 9999)
{
    num = (num / 100) % 10;
    result = num;
    Console.WriteLine($"Третье число {result} ");
}
else if (num >= 999)
{
    num = (num / 10) % 10;
    result = num;
    Console.WriteLine($"Третье число {result} ");

}
else if (num >= 100)
{
    num = num % 10;
    result = num;
    Console.WriteLine($"Третье число {result} ");
}
else if (num <= 99)
{

    Console.WriteLine($"Третье число отсутствует  ");
}




