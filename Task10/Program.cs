//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трёхзначное число");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA >= 100 & numberA <= 1000)
{
    int numberB = numberA % 100;
    int res = numberB / 10;
    Console.WriteLine($"Вторая цифра числа - {res}");
}
else
{
    Console.Write("Вы ввели не трехзначное число");
}