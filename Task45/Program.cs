/* Задача 45: Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.   */


int[] array = { 18, 52, 59, 33, 77 };
int[] newArr = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
    newArr[i] = array[i];
}
Console.WriteLine(string.Join("", array));
Console.WriteLine(string.Join("", newArr));