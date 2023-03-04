// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите любое натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите любое натуральное число степени");
int stepen = Convert.ToInt32(Console.ReadLine());

int Metodika(int number, int stepen)
{
    int result = 1;
    int i = 0;
    while (i < stepen)
    {
        i++;
        result *= number;
    }
    return result;
}
int res = Metodika(number, stepen);
Console.WriteLine(res);