// Напишите программу, которая выводит случайное целое число и 
// удаляет вторую цифру этого числа.


// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = Convert.ToInt32(Math.Log10(num));
// Console.WriteLine($"Разрядность числа - {i}");
// int stepen = i;
// int num1 = Convert.ToInt32(Math.Pow(10, stepen));
// int num2 = num / num1;
// int num3 = Convert.ToInt32(Math.Pow(10, stepen - 1));
// int num4 = num % num3;
// Console.WriteLine($"Полученное чисо - {num2}{num4}");


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