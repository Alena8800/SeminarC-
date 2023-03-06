// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

void Pol(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
count++;
}
Console.WriteLine($"из {array.Length} чисел, {count} четных");
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Задайте длину массива:  ");
int arrSize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrSize];
FillArray(array);
Console.WriteLine("В массиве: ");
Pol(array);
PrintArray(array);





