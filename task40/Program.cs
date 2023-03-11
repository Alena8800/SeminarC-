// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите  число a");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите  число b");
int b = Convert.ToInt32(Console.ReadLine());
  
Console.WriteLine("Введите  число c");
int c = Convert.ToInt32(Console.ReadLine());
  


void str(int a, int b, int c)
{
    if (a < b + c && c < b + a && b < a + c)
    {
Console.WriteLine("может");
    }
    else
    Console.WriteLine("нет");
}
str(a,  b,  c);