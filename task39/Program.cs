// Задача 39: Напишите программу, которая перевернёт одномерный 
// массив (последний элемент будет на первом месте, а первый - на 
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 100);
}

void PrintArray(int[] array)
{
  foreach (var el in array)
    Console.Write($"{el} ");
  Console.WriteLine();
}

void Reverse(int[] array)
{
    int temp;
    int size = array.Length;
    for (int i=0;i<size/2;i++)
        {
            // temp = array[i]; 
            // array[i]=array[size-1-i];
            // array[size-1-i] = temp;
            (array[i], array[size-1-i]) = (array[size-1-i], array[i]);//второй вариант метод двойнго присваивания
        }
}

int[] array = new int [7];
FillArray(array);
PrintArray(array);
Reverse(array);
PrintArray(array);