//Задача 14: Напишите программу, которая принимает на вход число и проверяет,
//кратно ли оно одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да
Console.WriteLine("Введите число");
int namber = Convert.ToInt32(Console.ReadLine());
if (namber % 7 == 0 | namber % 23 == 0)
{
    Console.WriteLine("да, кратно");
}
else
{
    Console.WriteLine("нет, не кратно");
}