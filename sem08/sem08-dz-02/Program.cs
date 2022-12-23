// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int findIndexMin(int[] array){
    int min = array[0],
        iMin = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] < min){
            min = array[i];
            iMin = i;
        }
    }
    return iMin;
}

int[] findSumRow(int[,] matrix){
	int rows = Convert.ToInt32(matrix.GetLongLength(0)),
		cols = Convert.ToInt32(matrix.GetLongLength(1));
    int[] sumRows = new int[rows];
	for(int i = 0; i < rows; i++){
		for(int j = 0; j < cols; j++){
            sumRows[i] += matrix[i,j];
        }
	}
    return sumRows;
}

void printMatrix(int[,] matrix){
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
int[] sumRows = findSumRow(matrix);
int iMin = findIndexMin(sumRows);
Console.WriteLine($"Минимальная сумма элементов = {sumRows[iMin]} в строке {iMin+1} ([{iMin}]).");
