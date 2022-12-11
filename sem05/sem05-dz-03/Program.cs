// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] createArray(int length){
	double[] array = new double[length];
	for(int i = 0; i < length; i++){
		array[i] = Math.Round(new Random().Next(-9, 10) + new Random().NextDouble(), 2);
	}
	return array;
}

void printArray(double[] array){
	foreach(double element in array){
		Console.Write($"{element} ");
	}
	Console.WriteLine();
}

double[] diffMinMax(double[] array){
	double[] result = new double[3]{array[0], array[0], 0};
	for(int i = 0; i < array.Length; i++){
		if(array[i] < result[0]) result[0] = array[i];
		else if(array[i] > result[1]) result[1] = array[i];
	}
	result[2] = Math.Round(result[1] - result[0], 2);
	return result;
}

Console.Write("Введите размерность массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = createArray(length);
printArray(array);
double[] result = diffMinMax(array);
Console.WriteLine($"min = {result[0]}, max = {result[1]}, diff = {result[2]}");
