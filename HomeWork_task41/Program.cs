﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько
//  чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
Console.WriteLine(message);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}


int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1} - й элемент");
    }
    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"а [{i}]={array[i]}");
    }
}


int CountPosotiveNumbers(int[]array)
{
   int count =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
            count++;
        }
    }
    return count; 
}


int lenght = Prompt("Введите количество элементов > ");
int[] array;
array = InputArray(lenght);
PrintArray(array);
Console.WriteLine($"Количесво чисел больше 0 - {CountPosotiveNumbers(array)}");
