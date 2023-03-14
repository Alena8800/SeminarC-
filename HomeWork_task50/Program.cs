// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 21);
}

void Num(int[,] array)
{
    Console.WriteLine("Введите значение элемента ");
    int numbers = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++) 
    if (numbers == array[i,j])
    {
        Console.WriteLine($" Число {numbers} есть в массиве");
        
    }
    else
        Console.WriteLine("В массиве нет заданного числа");
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3} \t");// ,3 - обозначает вырвниавание (у нас 2циф + 1 на минус)
        Console.WriteLine();// \t - означает табуляцию пробелы между столбцами 
    }
}


int[,] array = new int[3, 4];
FillArray(array);
Console.WriteLine("Массив:  ");
PrintArray(array);
Num(array);

