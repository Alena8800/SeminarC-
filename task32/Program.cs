// Задача 32: Напишите программу замена элементов массива: положительные элементы замените
//  на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-20, 20);
}

int[] RevArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = -array[i];
  return array;
}

void PrintArray(int[] array)
{
  foreach (var el in array)
    Console.Write($"{el} ");
  Console.WriteLine();
}

int[] array = new int[12];
FillArray(array);
PrintArray(array);
RevArray(array);
PrintArray(array);



