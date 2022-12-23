// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

int[,] multMatrix(int[,]matrixA, int[,]matrixB){
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    int sum = 0;
    for(int i = 0; i < matrixA.GetLength(0); i++){
		for(int j = 0; j < matrixB.GetLength(1); j++){
            for(int k = 0; k < matrixA.GetLength(1); k++){
                sum += matrixA[i, k] * matrixB[k, j];
            }
            matrixC[i, j] = sum;
            sum = 0;
        }
    }
    return matrixC;
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
			matrix[i, j] = new Random().Next(-9,10);
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

int[,] matrixA = createMatrix();
int[,] matrixB = createMatrix();
fillMatrix(matrixA);
fillMatrix(matrixB);
Console.WriteLine("Матрица А:");
printMatrix(matrixA);
Console.WriteLine("Матрица B:");
printMatrix(matrixB);
if(matrixA.GetLength(1) == matrixB.GetLength(0)){
    int[,] matrixC = multMatrix(matrixA, matrixB);
    Console.WriteLine("Произведение:");
    printMatrix(matrixC);
}else{
    Console.WriteLine("Данные матрицы нельзя перемножить.\nЧисло столбцов матрицы А должно быть равно количеству строк матрицы В");
}
