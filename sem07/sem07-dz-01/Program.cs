// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void printArray(double[,] array){
	for (int i = 0; i < array.GetLength(0); i++){
		for (int j = 0; j < array.GetLength(1); j++){
			Console.Write($"{array[i,j],5}\t");
		}
		Console.WriteLine();
	}
}

void fillArray(double[,] array){
	for (int i = 0; i < array.GetLength(0); i++){
		for (int j = 0; j < array.GetLength(1); j++){
			array[i, j] = Math.Round(new Random().Next(-9, 10) + new Random().NextDouble(), 2);
		}
	}
}

double[,] createArray(){
	Console.WriteLine("Введите параметры двумерного массива:");
	Console.Write("Количество строк: ");
	int rows = Convert.ToInt32(Console.ReadLine());
	Console.Write("Количество столбцов: ");
	int cols = Convert.ToInt32(Console.ReadLine());
	double[,] array = new double[rows, cols];
	return array;
}

double[,] numbers = createArray();
fillArray(numbers);
printArray(numbers);
