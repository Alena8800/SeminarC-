// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckThePalindrome(int number, int palindrome1, int palindrome2, int palindrome3, int palindrome4)
{
    if (number >= 10000 && number <= 99999)
    {
        Console.WriteLine();
        if (palindrome1 == palindrome2 && palindrome3 == palindrome4)
        {
            Console.WriteLine("Палиндром");
        }
        else
        {
            Console.WriteLine("Не палиндром");
        }
    }
    else
    {
        Console.WriteLine("Введено неверное число");
    }
}
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int palindrome1 = number % 10;
int palindrome2 = number / 10000;
int palindrome3 = number % 100 / 10;
int palindrome4 = number / 1000 % 10;
CheckThePalindrome(number, palindrome1, palindrome2, palindrome3, palindrome4);
