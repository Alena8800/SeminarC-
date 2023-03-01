// Напишите программу, которая принимает на вход координаты двух точек и 
// // находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

void Distance(int x1, int y1, int x2, int y2)
{
  double n = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));


  Console.WriteLine($"Расстояние составляет {n}");
}

Console.WriteLine("Введите координату х1 и у1");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату х2 и у2");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

Distance(x1, y1, x2, y2);