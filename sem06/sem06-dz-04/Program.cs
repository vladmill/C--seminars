// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, найти максимальное число и его индекс. 
// Вывести эту информацию на экран.

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

int[] findMinMax(int[,] array){
	int[] result = new int[6]{0, 0, 0, 0, array[0,0], array[0,0]};
	for (int i = 0; i < array.GetLength(0); i++){
		for (int j = 0; j < array.GetLength(1); j++){
			if(array[i, j] < result[4]){
				result[0] = i;
				result[1] = j;
				result[4] = array[i, j];
			}
			else if(array[i, j] > result[5]){
				result[2] = i;
				result[3] = j;
				result[5] = array[i, j];
			}
		}
	}
	return result;
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
int[] minMax = findMinMax(array);
Console.WriteLine($"Минимальное значение:  [{minMax[0]}, {minMax[1]}] = {minMax[4]}");
Console.WriteLine($"Максимальное значение: [{minMax[2]}, {minMax[3]}] = {minMax[5]}");