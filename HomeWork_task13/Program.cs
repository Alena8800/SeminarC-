// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int GetThirdRank(int number)
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     return number % 10;
// }

// bool ValidateNumber(int number)
// {
//     if (number<1000)
//     {
//         System.Console.WriteLine("Третьей цифры нет");
//         return false;
//     }
//     return true;
// }
//  int number = Prompt ("Введите число   ");
//  if (ValidateNumber(number))
//  {
//     System.Console.WriteLine(GetThirdRank (number));
//  }

int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
Console.WriteLine("Введите число   ");
int number = Convert.ToInt32(Console.ReadLine());

bool ValidateNumber(int number)
{
    if (number<1000)
    {
        System.Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}
if (ValidateNumber(number))
 {
    System.Console.WriteLine(GetThirdRank (number));
 }