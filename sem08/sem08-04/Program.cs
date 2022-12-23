// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

void printMatrix(int[,] matrix){
	Console.WriteLine();
	for (int i = 0; i < matrix.GetLength(0); i++){
		for (int j = 0; j < matrix.GetLength(1); j++){
			Console.Write($"{matrix[i,j],2}\t");
		}
		Console.WriteLine("\n");
	}
}

int randomUnicNumber(int[,] matrix){
	int number = new Random().Next(0, 100);
	for (int i = 0; i < matrix.GetLength(0); i++){
		for (int j = 0; j < matrix.GetLength(1); j++){
			if(matrix[i, j] == number){
				return randomUnicNumber(matrix);
			}
		}
	}
	return number;
}

int[] findIndexMin(int[,] matrix){
    int min = matrix[0, 0];
    int[] indexMin = new int[2]{0, 0};
    for (int i = 0; i < matrix.GetLength(0); i++){
		for (int j = 0; j < matrix.GetLength(1); j++){
			if(matrix[i, j] < min){
                min = matrix[i, j];
                indexMin[0] = i;
                indexMin[1] = j;
            }
		}
	}
    return indexMin;
}

int[,] delRowColMin(int[,] matrix, int[] iDel){
    int rows = Convert.ToInt32(matrix.GetLongLength(0)) - 1,
		cols = Convert.ToInt32(matrix.GetLongLength(1)) - 1,
        ix = 0,
        jx = 0;
    int[,] newMatrix = new int[rows, cols];
    for (int i = 0; i < rows; i++){
        if(i >= iDel[0]) ix = i + 1;
        else ix = i;
        for (int j = 0; j < cols; j++){
            if(j >= iDel[1]) jx = j + 1;
            else jx = j;
            newMatrix[i, j] = matrix[ix, jx];
        }
    }
    return newMatrix;
}

void fillMatrix(int[,] matrix){
	for (int i = 0; i < matrix.GetLength(0); i++){
		for (int j = 0; j < matrix.GetLength(1); j++){
			matrix[i, j] = randomUnicNumber(matrix);
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
int[] iMin = findIndexMin(matrix);
Console.WriteLine($"Минимальное значение [{iMin[0]}, {iMin[1]}] = {matrix[iMin[0], iMin[1]]}");
int[,] newMatrix = delRowColMin(matrix, iMin);
printMatrix(newMatrix);