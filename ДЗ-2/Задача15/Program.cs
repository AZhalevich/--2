﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.WriteLine("Введите номер дня недели:");
int num = int.Parse(Console.ReadLine()!);

if (num >= 1 && num <=5)
{
    Console.WriteLine("Будний день");}

else if (num > 5 && num <=7)
{
    Console.WriteLine("Выходной");
}
else if (num < 1 || num > 7)
 Console.WriteLine("Ведён не корректный номер");