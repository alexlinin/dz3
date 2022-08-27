/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите целое число от 1 и выше до которого показывать кубы чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int index = 1;

for (index = 1; index <= n; index++)
{
Console.WriteLine(Math.Pow(index, 3));
}