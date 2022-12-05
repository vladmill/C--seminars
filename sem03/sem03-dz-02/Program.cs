// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве.
// Сначала задается N с клавиатуры, потом задаются координаты точек.

Console.Clear();
Console.Write("Введите размерность пространства: ");
int D = Convert.ToInt32(Console.ReadLine());
double[] coordA = new double[D];
double[] coordB = new double[D];
Console.WriteLine();
for(int i = 0; i < D; i++){
	Console.Write($"Введите {i+1} координату точки A: ");
	coordA[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
for(int i = 0; i < D; i++){
	Console.Write($"Введите {i+1} координату точки B: ");
	coordB[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
double sumSquare = 0;
for(int i = 0; i < D; i++){
	sumSquare += Math.Pow((coordB[i] - coordA[i]), 2);
}
double distance = Math.Round(Math.Sqrt(sumSquare), 3);
Console.WriteLine($"Расстояние между точками А и В равно {distance}");
