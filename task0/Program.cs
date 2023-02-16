// // Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает
//  наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int num = new Random().Next(10,100);
Console.WriteLine("Было сгенерировано "+num);
Console.WriteLine($"Было сгенерировано число {num}");
int x1 = num / 10;
int x2 = num % 10;
if (x1>x2)
Console.WriteLine(x1);
else if (x1<x2)
Console.WriteLine(x2);
else
Console.WriteLine("обе цифры этого числа равны");