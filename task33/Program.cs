// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует 
// ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int Input(string msg)
{
  Console.WriteLine(msg);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-20, 20);
}

bool NumInArray(int[] array, int number)
{
  bool res = false;
  foreach (var el in array)
    if (el == number)
      res = true;
  return res;
}

void PrintArray(int[] array)
{
  foreach (var el in array)
    Console.Write($"{el} ");
  Console.WriteLine();
}

int number = Input("Введите число: ");
int[] array = new int[12];
FillArray(array);
PrintArray(array);
Console.WriteLine(NumInArray(array, number));

// ВТОРОЙ ВАРИАНТ
// void FillArray(int [] array)
// {
//     for (int i=0;i<array.Length;i++)
//         array[i] = new Random().Next(-9,10);
// }

// void PrintArray(int [] array)
// {
//     foreach (var el in array)
//         Console.Write($"{el} ");
//     Console.WriteLine();
// }
// void FindDigit(int[] array, int n)
// {
//     bool find = false;
//      for (int i=0;i<array.Length;i++)
//      {
//         if (array[i] == n)
//             {find = true; 
//             break;
//             }
//      }
//      if (find) 
//      Console.WriteLine("Нашли");
     
//         else
//            Console.WriteLine("Число НЕ присутсвует");
// }

// Console.WriteLine("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[12];
// FillArray(array);
// PrintArray(array);
// FindDigit(array, n);