// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

void swapRowsCols(int[,] matrix){
	for (int i = 0; i < matrix.GetLength(0); i++){
		for (int j = i; j < matrix.GetLength(1); j++){
			(matrix[i,j], matrix[j,i]) = (matrix[j,i], matrix[i,j]);
		}
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
	int numEl = rows * cols;
	if(rows != cols){
		Console.WriteLine($"Для выполнения программы нужна квадратная матрица. Попробуйте еще раз.\n");
		return createMatrix();
	}else{
		int[,] matrix = new int[rows,cols];
		return matrix;
	}
}

int[,] matrix = createMatrix();
fillMatrix(matrix);
printMatrix(matrix);
swapRowsCols(matrix);
Console.WriteLine("Строки стали столбцами, а столбцы строками:");
printMatrix(matrix);