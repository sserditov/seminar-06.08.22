// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine("Введите цифру");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA == 6 | numberA == 7)
{
    Console.WriteLine("Ураа! Выходной");
}
else if (numberA < 1 | numberA > 7)
{
    Console.WriteLine("будни");
}
else
{
    Console.WriteLine("будни");
}