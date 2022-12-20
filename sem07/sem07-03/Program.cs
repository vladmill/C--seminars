// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

void printArray(int[,] array){
	for (int i = 0; i < array.GetLength(0); i++){
		for (int j = 0; j < array.GetLength(1); j++){
			Console.Write($"{array[i,j],2}\t");
		}
		Console.WriteLine();
	}
}

void fillArray(int[,] array){
	for (int i = 0; i < array.GetLength(0); i++){
		for (int j = 0; j < array.GetLength(1); j++){
			array[i, j] = new Random().Next(1,10);
		}
	}
}

int sumDiagonal(int[,] array){
	int sum = 0;
	for (int i = 0; i < array.GetLength(0); i++){
		for (int j = 0; j < array.GetLength(1); j++){
			if(i == j){
				sum += array[i,j];
			}
		}
	}
	return sum;
};

int sumDiagonalRev(int[,] array){
	int sum = 0;
	for (int i = 0; i < array.GetLength(0); i++){
		for (int j = 0; j < array.GetLength(1); j++){
			if(i == array.GetLength(0) - 1 - j && j == array.GetLength(1) - (array.GetLength(0) - j)){
			//if(array.GetLength(0) - 1 - i == j){
				sum += array[i,j];
			}
		}
	}
	return sum;
};

int[,] createArray(){
	Console.WriteLine("Введите параметры двумерного массива:");
	Console.Write("Количество строк: ");
	int rows = Convert.ToInt32(Console.ReadLine());
	Console.Write("Количество столбцов: ");
	int cols = Convert.ToInt32(Console.ReadLine());
	int[,] array = new int[rows, cols];
	return array;
}

int[,] array = createArray();
fillArray(array);
printArray(array);
Console.WriteLine($"Cумма элементов главной диагонали: {sumDiagonal(array)}");
Console.WriteLine($"Cумма элементов обратной диагонали: {sumDiagonalRev(array)}");