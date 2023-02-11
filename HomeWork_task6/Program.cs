// Задача 6: Напишите программу, которая на вход принимает
// число и выдает, является ли число четным (делится ли оно на
// два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number % 2;
if (number1 == 0)
{
    Console.WriteLine("Четное число");
}
else  
{
   Console.WriteLine("Нечетное");
}