// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

void printArray(int[,] array){
	for (int i = 0; i < array.GetLength(0); i++){
		for (int j = 0; j < array.GetLength(1); j++){
			Console.Write($"{array[i,j],3}\t"); // ",3" - подвывод резервирует 3 символа
		}
		Console.WriteLine();
	}
}

void fillArray(int[,] array){
	for (int i = 0; i < array.GetLength(0); i++){
		for (int j = 0; j < array.GetLength(1); j++){
			array[i, j] = new Random().Next(-20,21);
		}
	}
}

Console.WriteLine("Введите параметры двумерного массива:");
Console.Write("Количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
fillArray(array);
printArray(array);
