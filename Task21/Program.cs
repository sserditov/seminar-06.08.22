/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 2D пространстве.
 A (3,6); B (2,1) -> 5,09
 A (7,-5); B (1,-1) -> 7,21
 √(xb - xa)2 + (yb - ya)2 */

Console.ReadLine().Split().Select(Convert.ToInt32).ToArray();


Console.WriteLine("Введите координаты точки 1 по x");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки 1 по y");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки 2 по x");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки 2 по y");
double y2 = Convert.ToDouble(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

Console.WriteLine($"{res:f2}"); /* f2 сколько занков после запятой */
