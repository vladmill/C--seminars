// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

void swapRows(int[,] matrix){
	int rows = Convert.ToInt32(matrix.GetLongLength(0)),
		cols = Convert.ToInt32(matrix.GetLongLength(1));
		//temp = 0;
	for (int j = 0; j < cols; j++){
		// temp = matrix[0,j];
		// matrix[0,j] = matrix[rows-1,j];
		// matrix[rows-1,j] = temp;
		(matrix[0,j], matrix[rows-1,j]) = (matrix[rows-1,j], matrix[0,j]);
	}
}

void printMatrix(int[,] matrix){
	Console.WriteLine();
	for (int i = 0; i < matrix.GetLength(0); i++){
		for (int j = 0; j < matrix.GetLength(1); j++){
			Console.Write($"{matrix[i,j],3}\t");
		}
		Console.WriteLine("\n");
	}
}

void fillMatrix(int[,] matrix){
	for (int i = 0; i < matrix.GetLength(0); i++){
		for (int j = 0; j < matrix.GetLength(1); j++){
			matrix[i, j] = new Random().Next(-99, 100);
		}
	}
}

int[,] createMatrix(){
	Console.WriteLine("Введите параметры матрицы:");
	Console.Write("Количество строк: ");
	int rows = Convert.ToInt32(Console.ReadLine());
	Console.Write("Количество столбцов: ");
	int cols = Convert.ToInt32(Console.ReadLine());
	int[,] matrix = new int[rows,cols];
	return matrix;
}

int[,] matrix = createMatrix();
fillMatrix(matrix);
printMatrix(matrix);
swapRows(matrix);
Console.WriteLine("Первая и последняя строка массива поменялись:");
printMatrix(matrix);