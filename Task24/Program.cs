﻿/* Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */

Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.RedLine());
int sum = 0;
for (int i = 1; i <= A; i++) ;
{
    sum = sum + i; /* sum +=i */
}
Console.WriteLine($ "Сумма чиселот 1 до А");