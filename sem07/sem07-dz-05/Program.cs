// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры), 
// причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей. 
// Перемешать случайным образом элементы массива, 
// причем чтобы каждый элемент гарантированно и только один раз переместился на другое место 
// и выполнить перемешивание за m*n / 2 итераций. 
// То есть если массив три на четыре, то надо выполнить за 6 итераций. 
// И далее в конце опять вывести на экран как таблицу.

int[] findRandomIndex(int[,]disabledI){
	int rows = Convert.ToInt32(disabledI.GetLongLength(0)),
		cols = Convert.ToInt32(disabledI.GetLongLength(1)),
		i = new Random().Next(0, rows/2),
		j = new Random().Next(0, cols);
		if(disabledI[i,j] == 1){
			return findRandomIndex(disabledI);
		}else{
			disabledI[i,j] = 1;
			int[] result = new int[2]{i, j};
			return result;
		}
}

int shuffling(int[,] matrix, int[,]disabledI){
	int rows = Convert.ToInt32(matrix.GetLongLength(0)),
		cols = Convert.ToInt32(matrix.GetLongLength(1)),
		temp = 0,
		count = 0;
	for (int i = 0; i < rows/2; i++){
		for (int j = 0; j < cols; j++){
			int lastI = rows - 1 - i,
				lastJ = cols - 1 - j;
			int[] rand = findRandomIndex(disabledI);
			temp = matrix[rand[0],rand[1]];
			matrix[rand[0],rand[1]] = matrix[lastI,lastJ];
			matrix[lastI,lastJ] = temp;
			disabledI[lastI,lastJ] = 1;
			count += 1;
		}
	}
	return count;
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

int randomUnicNumber(int[,] matrix){
	int number = new Random().Next(-99, 100);
	for (int i = 0; i < matrix.GetLength(0); i++){
		for (int j = 0; j < matrix.GetLength(1); j++){
			if(matrix[i, j] == number){
				return randomUnicNumber(matrix);
			}
		}
	}
	return number;
}

void fillMatrix(int[,] matrix){
	for (int i = 0; i < matrix.GetLength(0); i++){
		for (int j = 0; j < matrix.GetLength(1); j++){
			matrix[i, j] = randomUnicNumber(matrix);
		}
	}
}

int[,] createMatrix(){
	Console.WriteLine("Введите параметры матрицы с чётным количеством элементов:");
	Console.Write("Количество строк: ");
	int rows = Convert.ToInt32(Console.ReadLine());
	Console.Write("Количество столбцов: ");
	int cols = Convert.ToInt32(Console.ReadLine());
	int numEl = rows * cols;
	if(numEl % 2 == 1){
		Console.WriteLine($"Необходимо чётное число элементов. Так их будет {numEl}. Попробуйте еще раз.\n");
		return createMatrix();
	}else{
		int[,] matrix = new int[rows,cols];
		return matrix;
	}
}

int[,] matrix = createMatrix();
int[,] disabledI = new int[matrix.GetLength(0),matrix.GetLength(1)];
fillMatrix(matrix);
printMatrix(matrix);
int count = shuffling(matrix, disabledI);
Console.WriteLine($"Результат {count} итераций перемешивания:");
printMatrix(matrix);