// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату X точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());

double length = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2));
Console.WriteLine($"Расстояние между точками А и В равно {length}");
