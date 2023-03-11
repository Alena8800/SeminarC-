// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next();
}

void Sum(int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i+=2)
sum = sum + array[i];
Console.WriteLine($"из {array.Length} чисел, сумма чисел на нечетных позициях = {sum} ");
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
Sum(array);
PrintArray(array);
