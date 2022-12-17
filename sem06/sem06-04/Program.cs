// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] createArray(int length){
	int[] array = new int[length];
	for(int i = 0; i < length; i++){
		array[i] = new Random().Next(100,1000);
	}
	return array;
}

void printArray(int[] array){
	foreach(int element in array){
		Console.Write($"{element} ");
	}
	Console.WriteLine();
}

int[] copyArray(int[] array){
	int length = array.Length;
	int[] result = new int[length];
	for(int i = 0; i < length; i++){
		result[i] = array[i];
	}
	return result;
}

Console.Write("Введите размерность массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arrayFirst = createArray(length);
printArray(arrayFirst);
int[] arraySecond = copyArray(arrayFirst);
printArray(arraySecond);