// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Input(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}


 int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Akkerman(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    else
        return n + 1;
}

int m = Input("Введите число m:");
int n = Input("Введите число n:");
Console.WriteLine($" Результат вычисления функции Аккермана {Akkerman(m, n)}");
