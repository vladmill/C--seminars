// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

void sortBubble(int[,] array){
	int rows = Convert.ToInt32(array.GetLongLength(0)),
		cols = Convert.ToInt32(array.GetLongLength(1)),
		rowsCols = rows * cols,
		temp = 0;
	for(int k = 0; k < rowsCols; k++){
		for(int i = 0; i < rows; i++){
			for (int j = 0; j < cols; j++){
				if(i != rows-1 && j == cols-1){
					if(array[i,j] > array[i+1,0]){
						temp = array[i,j];
						array[i,j] = array[i+1,0];
						array[i+1,0] = temp;
					}
				}
				else if(j != cols-1){
					if(array[i,j] > array[i,j+1]){
						temp = array[i,j];
						array[i,j] = array[i,j+1];
						array[i,j+1] = temp;
					}
				} 
			}
		}
	}
}

void printArray(int[,] array){
	for (int i = 0; i < array.GetLength(0); i++){
		for (int j = 0; j < array.GetLength(1); j++){
			Console.Write($"{array[i,j],3}\t");
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
sortBubble(array);
Console.WriteLine("Отсортированный массив: ");
printArray(array);
