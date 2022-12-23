// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

void fillMatrixSpiral(int[,] matrix){
    int rows = Convert.ToInt32(matrix.GetLongLength(0)),
		cols = Convert.ToInt32(matrix.GetLongLength(1)),
        counter = 1,
        rowS = 0,
        rowE = rows - 1,
        colS = 0,
        colE = cols - 1;
    while(counter <= rows * cols){
        for(int j = colS; j <= colE; j++){
            matrix[rowS, j] = counter;
            counter += 1;
        }
        rowS += 1;
        for(int i = rowS; i <= rowE; i++){
            matrix[i, colE] = counter;
            counter += 1;
        }
        colE -= 1;
        for(int j = colE; j >= colS; j--){
            matrix[rowE, j] = counter;
            counter += 1;
        }
        rowE -= 1;
        for(int i = rowE; i >= rowS; i--){
            matrix[i, colS] = counter;
            counter += 1;
        }
        colS += 1;
    }
}

void printMatrix(int[,] matrix){
    Console.WriteLine();
	for(int i = 0; i < matrix.GetLength(0); i++){
		for(int j = 0; j < matrix.GetLength(1); j++){
			Console.Write($"{matrix[i,j],3}\t");
		}
		Console.WriteLine("\n");
	}
}

Console.WriteLine("Введите параметры матрицы:");
Console.Write("Количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, cols];
fillMatrixSpiral(matrix);
printMatrix(matrix);