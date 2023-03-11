// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10




void Change(int number)
{
    string i = "";//создали пустую строку
    while (number > 0)
    {
        i = number % 2+i;// +1 записывает сразу в обратном порядке
        number /=2;//делим на 2
    }
    Console.WriteLine(i);
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Change(number);