// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

void FillArray(int[] array)  //метод для заполнения массива
{
    for (int i = 0; i < array.Length; i++) //с массивами проще работать через фор
        array[i] = new Random().Next(-9, 10); // заполнить массив случ числами от -9 до 9
}

void PrintArray(int[] array)//метод для вывода массива на экран
{
    foreach (var el in array)// цикл форитч просматривает все эл-ты без индекса и можно вевести все 
                             // эл-ты через пробел. переменная el превращается по очереди в кажлдый
                             // элемент массива НО цикл форитч не может менять содержимое
        Console.Write($"{el} ");
    Console.WriteLine();
}


void FindSums(int[] array)//для суммы
{
    int sumP = 0;
    int sumN = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            sumP += array[i];
        else
            sumN += array[i];
    Console.WriteLine($"Сумма положительных элементов равна {sumP}");
    Console.WriteLine($"Сумма отрицательных элементов равна {sumN}");
}


// ВТОРОЙ СПОСОБ создали массив из 2х эл-ов ,где в инд 0 запис полож,а в инд 1 отриц и возвр массив из 2х эл
int[] FindSums2(int[] array)
{
    int[] results = new int[2];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            results[0] += array[i];
        else
            results[1] += array[i];
    return results;
}




int[] array = new int[5]; //создать новый массив
FillArray(array);
PrintArray(array);
FindSums(array);
PrintArray(FindSums2(array));