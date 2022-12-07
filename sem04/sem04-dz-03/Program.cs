// Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.

// int length = 8;
// int[] array = new int[length];

int[] fillArray(int length){
	int[] array = new int[length];
	Console.WriteLine("Введите значения элементов массива:");
	for(int i = 0; i < length;  i++){
		Console.Write($"[{i}] =  ");
		array[i] = Convert.ToInt32(Console.ReadLine());
	}
	return array;
}

void printArray(int[] array, int length){
	Console.Write("\nВаш массив: [");
	for(int i = 0; i < length; i++){
		if(i == 0) Console.Write(array[i]);
		Console.Write($", {array[i]}");
	}
	Console.Write("]");
}

Console.Write("Введите размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
printArray(fillArray(length), length);
