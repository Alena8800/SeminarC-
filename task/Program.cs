// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите любое натуральное число");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите любое натуральное число степени");
int numberB = Convert.ToInt32(Console.ReadLine());

int Metodika(int numberB, int numberA)
{
    int result = 1;
    int i = 0;
    while (i < numberA)
    {
        i++;
        result *= numberB;
    }
    return result;
}
int res = Metodika(numberA, numberB);
Console.WriteLine(res);