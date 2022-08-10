// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите трёхзначное число");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA >= 100 & numberA <= 1000)
{
    int numberB = numberA % 10;
    //int res = numberB / 1;
    Console.WriteLine(numberB);
}
else
{
    Console.Write("третьей цифры нет");
}