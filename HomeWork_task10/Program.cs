// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите любое число в диапазоне от 100 до 999");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num <= 999)
{
int num1 = num /10;
int num2 = num1 %10;
System.Console.WriteLine($"Вторая цифра числа {num} -  {num2}");
}
else
{
System.Console.WriteLine("Введено неверное число ");
}