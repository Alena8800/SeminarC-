// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной и 
// обратной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 
// 5 9 2 
// 8 4 2 
// Сумма элементов главной диагонали: 1+9+2 = 12
// Сумма элементов обратной диагонали: 8+9+7 = 24

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      array[i, j] = new Random().Next(0, 10);
}

void SumDiagArray(int[,] array)
{
  int sumDiag1 = 0;
  int sumDiag2 = 0;
  int j = array.GetLength(1)-1;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    sumDiag1 += array[i, i];
    sumDiag2 += array[i, j];
    j--;
  }
  Console.WriteLine($"Сумма элементов главной диагонали: {sumDiag1}");
  Console.WriteLine($"Сумма элементов обратной диагонали: {sumDiag2}");
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write($"{array[i, j]} \t");
    Console.WriteLine();
  }
}

int[,] array = new int[3, 3];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SumDiagArray(array);
