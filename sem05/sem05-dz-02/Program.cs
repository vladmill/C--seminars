// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] createArray(int length){
	int[] array = new int[length];
	for(int i = 0; i < length; i++){
		array[i] = new Random().Next(-99,100);
	}
	return array;
}

void printArray(int[] array){
	foreach(int element in array){
		Console.Write($"{element} ");
	}
	Console.WriteLine();
}

int sumOdd(int[] array){
	int sum = 0;
	for(int i = 0; i < array.Length; i++){
		if(i % 2 != 0) sum += array[i];
	}
	return sum;
}

Console.Write("Введите размерность массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = createArray(length);
printArray(array);
Console.WriteLine($"Сумма элементов с нечетными индексами: {sumOdd(array)}");