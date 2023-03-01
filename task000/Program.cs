// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void PrintMass(int[] arr)
{
  Random rnd = new Random();
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(0, 2);
    Console.Write($"{arr[i]} ");
  }
}
int[] array = new int[8];
PrintMass(array);



// Второй вариант
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine();
// }

// int[] arr = { 0, 1, 1, 1, 0, 0, 1, 1 };
// PrintArray(arr);