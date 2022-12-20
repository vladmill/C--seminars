// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void printMatrix(int[,] matrix){
	Console.WriteLine();
	for (int i = 0; i < matrix.GetLength(0); i++){
		for (int j = 0; j < matrix.GetLength(1); j++){
			Console.Write($"{matrix[i,j],2}\t");
		}
		Console.WriteLine();
	}
}
void printArray(double[] array){
	foreach(double element in array){
		Console.Write($"{element}\t");
	}
	Console.WriteLine();
}

void fillArray(int[,] array){
	for (int i = 0; i < array.GetLength(0); i++){
		for (int j = 0; j < array.GetLength(1); j++){
			array[i, j] = new Random().Next(-9, 10);
		}
	}
}

double[] findAverageCols(int[,] array){
	int rows = Convert.ToInt32(array.GetLongLength(0)),
		cols = Convert.ToInt32(array.GetLongLength(1));
	double[] result = new double[cols];
	for (int i = 0; i < rows; i++){
		for (int j = 0; j < cols; j++){
			result[j] += array[i,j];
		}
	}
	for (int i = 0; i < cols; i++){
		result[i] = Math.Round(result[i] / rows, 2);
	}
	return result;
}

Console.WriteLine("Введите параметры двумерного массива:");
Console.Write("Количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];

fillArray(array);
printMatrix(array);
double[] averageCols = findAverageCols(array);
Console.WriteLine("Cреднее арифметическое элементов в каждом столбце:");
printArray(averageCols);

