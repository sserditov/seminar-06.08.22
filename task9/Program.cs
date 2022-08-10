// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Наше случайное {number} число"); // интерпаляция
int digit2 = number % 10; //получаем последнюю цифру
int digit1 = number / 10; //получаем первую цифру
if (digit1 > digit2)
{
    Console.Write(digit1);
}
else if (digit2 > digit1)
{
    Console.Write(digit2);
}
else
{
    Console.Write("Цифры равны");
}
