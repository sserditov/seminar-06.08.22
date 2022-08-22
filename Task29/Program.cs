/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов
 и выводит их на экран.
 Вводим массив через консоль 
int[] mas = { 8, 6, 3, 9, 11, 13, 7, 15 };
void function(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}
function(mas); */

int[] array = new int[8];

Console.WriteLine("Введите числа для массива");

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("массив");
Console.Write(string.Join(", ", array));


