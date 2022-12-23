// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void sortBubbleRow(int[,] matrix){
	int rows = Convert.ToInt32(matrix.GetLongLength(0)),
		cols = Convert.ToInt32(matrix.GetLongLength(1)),
		rowsCols = rows * cols;
	for(int k = 0; k < rowsCols; k++){
		for(int i = rows-1; i >= 0; i--){
			for(int j = cols-1; j >= 0; j--){
                if(j - 1 >= 0 && matrix[i,j] > matrix[i,j-1]){
                    (matrix[i,j], matrix[i,j-1]) = (matrix[i,j-1], matrix[i,j]);
                }
			}
		}
	}
}

void printMatrix(int[,] matrix){
    Console.WriteLine();
	for(int i = 0; i < matrix.GetLength(0); i++){
		for(int j = 0; j < matrix.GetLength(1); j++){
			Console.Write($"{matrix[i,j],3}\t");
		}
		Console.WriteLine();
	}
}

void fillMatrix(int[,] matrix){
	for(int i = 0; i < matrix.GetLength(0); i++){
		for(int j = 0; j < matrix.GetLength(1); j++){
			matrix[i, j] = new Random().Next(-20,21);
		}
	}
}

int[,] createMatrix(){
	Console.WriteLine("Введите параметры матрицы:");
	Console.Write("Количество строк: ");
	int rows = Convert.ToInt32(Console.ReadLine());
	Console.Write("Количество столбцов: ");
	int cols = Convert.ToInt32(Console.ReadLine());
	int[,] matrix = new int[rows, cols];
	return matrix;
}

int[,] matrix = createMatrix();
fillMatrix(matrix);
printMatrix(matrix);
sortBubbleRow(matrix);
Console.WriteLine("\nСтроки отсортированы в обратном порядке: ");
printMatrix(matrix);
