/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i;
int sum = 0;
for (i = 0; n >= 1; i++)
{
    sum += n % 10;
    n = n / 10;
}
Console.WriteLine("Сумма цифр в числе равна " + sum);