// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckThePalindrome(string palindrome)
{
    int number = palindrome.Length; 
    if (number == 5)
    {
        if (palindrome[0] == palindrome[4] && palindrome[1] == palindrome[3])
        {
            Console.WriteLine("Палиндром");
        }

        else
        {
            Console.WriteLine("Не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Ввели неверное число");
    }
}

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
string palindromeLength = Convert.ToString(number);
CheckThePalindrome("");