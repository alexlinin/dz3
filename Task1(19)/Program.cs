/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите целое пятизначное число: ");
string number = Console.ReadLine();

//Проверка на то, введено ли пятизначное число
if (number.Length != 5)
{
Console.WriteLine("Вы указали не пятизначное число");
}

// Проверка на то, является ли число палиндромом
else if ((number[0] == number[4]) && (number[1] == number[3]))
{
Console.WriteLine("Введенное число:" + " " + number + " является палиндромом");
}
else Console.WriteLine("Введенное число:" + " " + number + " не является палиндромом");
