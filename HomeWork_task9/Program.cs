// Задача 7
// Напишите программу,которая принимает на вход целое число любой разрядности 
// и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. 
// Через строку решать нельзя.
// 456111 -> 5
// 78 -> 8
// 9146548 -> 1
// 3 -> нет

int GetThirdRank(int number)
{
    while (number > 99)
    {
        number /= 10;
    }
    return number % 10;
}
Console.WriteLine("Введите число   ");
int number = Convert.ToInt32(Console.ReadLine());

bool ValidateNumber(int number)
{
    if (number<9)
    {
        System.Console.WriteLine("Второй цифры нет");
        return false;
    }
    return true;
}
if (ValidateNumber(number))
 {
    System.Console.WriteLine(GetThirdRank (number));
 }

