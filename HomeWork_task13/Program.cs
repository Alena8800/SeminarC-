// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int num2=num;
int count=0;
while (num > 0)
{
count++;
num = num / 10;
}
Console.WriteLine($"Разрядность введенного числа {count}");

string res="";
for (int i=1;i<=count;i++)
{
if (i!=count-1)
res = num2%10 + res ;
num2=num2/10;
}

Console.WriteLine(res);