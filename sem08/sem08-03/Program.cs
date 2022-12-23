// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

void printDictionary(int[] array){
	for (int i = 0; i < array.Length; i++){
		if(array[i] != 0){
			Console.WriteLine($"{i} встречается {array[i]} раз(а)");
		}
	}
	Console.WriteLine();
}

int[] createDictionary(int[,] matrix){
	int[] result = new int[10]; // количество  уникальных чисел (random)
	for (int i = 0; i < Convert.ToInt32(matrix.GetLongLength(0)); i++){
		for (int j = 0; j < Convert.ToInt32(matrix.GetLongLength(1)); j++){
			result[matrix[i,j]] += 1; 
		}
	}
	return result;
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
			matrix[i, j] = new Random().Next(0, 10);
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
int[] dictionary = createDictionary(matrix);
printDictionary(dictionary);