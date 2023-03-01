// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.WriteLine("Введите натуральное: ");
int x = Convert.ToInt32(Console.ReadLine());
int x1 = x;
string res = $"{x} -> ";
for (int i = 1; i <= x; i++){
    int tmp = i * i;
    res += $"{tmp}, ";
}
Console.WriteLine(res);