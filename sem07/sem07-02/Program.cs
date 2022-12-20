// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.

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

void changeArray(int[,] array){
	for (int i = 0; i < array.GetLength(0); i++){
		for (int j = 0; j < array.GetLength(1); j++){
			if(i % 2 != 0 && j % 2 != 0){
				array[i,j] = array[i,j] * array[i,j];
			}
		}
	}
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
Console.WriteLine("Квадраты элементов с нечетными индексами:");
changeArray(array);
printArray(array);