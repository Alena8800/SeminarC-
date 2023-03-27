// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Input(string message)
{
  int result = 0;
  Console.WriteLine(message);
  result = Convert.ToInt32(Console.ReadLine());
  return result;
}

void NumberNatural (int number)
{
    if (number == 0) return;
    Console.Write($" {number},");
    NumberNatural (number - 1);
}

int number = Input("Введите число :");
Console.WriteLine();
NumberNatural(number);