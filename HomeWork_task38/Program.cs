// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}

void MinMax (double[]array)
{
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int b = 0; b < array.Length; b++)
{
    
    if (array[b] > max)
        {
            max = array[b];
        }
    else if (array[b] < min)
        {
            min = array[b];
        }

}
Console.WriteLine($"Всего в массиве {array.Length} чисел. Максимальное = {max}, Минимальное = {min}");
Console.WriteLine($"Разность между максимальным и минимальным = {max - min}");  
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Задайте длину массива:  ");
int arrSize = Convert.ToInt32(Console.ReadLine());
double[] array = new double[arrSize];
FillArray(array);
Console.WriteLine("массив: ");
PrintArray(array);
MinMax (array);

