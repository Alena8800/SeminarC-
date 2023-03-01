// / Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

Random rnd = new Random();
int[] array = new int[12];
int sumPol = 0;
int sumOtr = 0;

for (int i = 0; i < array.Length; i++)
{
  array[i] = rnd.Next(-9, 10);
  Console.Write($"{array[i]} ");
  if (array[i] < 0)
    sumOtr += array[i];
  else
    sumPol += array[i];
}

Console.WriteLine();
Console.Write($"Сумма положительных элементов: {sumPol}; Сумма отрицательных элементов: {sumOtr};");