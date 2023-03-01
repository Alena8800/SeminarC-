// Задача №17.
//  Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

try
{
    Console.WriteLine("Введите координату Х");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату Y");
    int y = Convert.ToInt32(Console.ReadLine());

    if (x > 0 && y > 0)
        Console.WriteLine("Точка находится в 1 четверти");
    else if (x > 0 && y < 0)
        Console.WriteLine("Точка находится в 4 четверти");
    else if (x < 0 && y < 0)
        Console.WriteLine("Точка находится в 3 четверти");
    else if (x < 0 && y > 0)
        Console.WriteLine("Точка находится в 2 четверти");
    else
        Console.WriteLine("Точка находится на координатной оси");
}
catch
{
    Console.WriteLine("Были введены некорректные данные");
}