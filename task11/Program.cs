﻿// Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число = {number}");
int digit1 = number / 100;
int digit3 = number % 10;

int res = digit1 * 10 + digit3;

Console.WriteLine($"Результат = {res}"); //Console.WriteLine($"{digit1}{digit3}"); - как альтернатива, но строка string