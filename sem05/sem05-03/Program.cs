// Задайте одномерный массив из 15 случайных чисел от -100 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] createArray(int length){
	int[] array = new int[length];
	for(int i = 0; i < length; i++){
		array[i] = new Random().Next(-100,101);
	}
	return array;
}

void printArray(int[] array){
	foreach(int element in array){
		Console.Write($"{element} ");
	}
	Console.WriteLine();
}

int countRelevant(int[] array, int[] segment){
	int count = 0;
	foreach(int element in array){
		if(element >= segment[0] && element <= segment[1]){
			count += 1;
		}
	}
	return count;
}

int[] segment = {10, 99};
int[] array = createArray(15);
printArray(array);
Console.WriteLine($"Количество соответствующих элементов равно {countRelevant(array, segment)}");
