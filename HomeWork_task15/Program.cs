// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

 Console.WriteLine("Введите номер дня");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1)
{
	Console.Write("Понедельник - не выходной");
}
else if (day == 2)
{
	Console.Write("Вторник - не выходной");
}
else if (day == 3)
{
	Console.Write("Среда - не выходной");
}
else if (day == 4)
{
	Console.WriteLine("Четверг - не выходной");
}
else if (day == 5)
{
	Console.WriteLine("Пятница - не выходной");
}
else if (day == 6)
{
	Console.WriteLine("Суббота - выходной");
}
else if (day == 7)
{
	Console.WriteLine("Воскресенье - выходной");
}
else 
{
	Console.WriteLine("Введены некоректные значения.");
}

