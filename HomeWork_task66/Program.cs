// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int Input(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SummaRec(int m, int n)
{
    if (n < m) return 0;
    else if (n == m) return n;
    return m + SummaRec(m + 1, n);
}


int m = Input("Введите число m:");
int n = Input("Введите число n:");
Console.WriteLine($"Сумма чисел от {m} до {n} равна {SummaRec(m, n)}");
