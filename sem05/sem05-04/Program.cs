// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] createArray(int length){
	int[] array = new int[length];
	for(int i = 0; i < length; i++){
		array[i] = new Random().Next(1,11);
	}
	return array;
}

void printArray(int[] array){
	foreach(int element in array){
		Console.Write($"{element} ");
	}
	Console.WriteLine();
}

int[] multiplication(int[] array){
	int length = array.Length,
		lenRes = length / 2 + length % 2;
	int[] result = new int[lenRes];
	for(int i = 0; i < lenRes; i++){
		if(i != length - 1 - i) result[i] = array[i] * array[length - 1 - i];
		else result[i] = array[i];
	}
	return result;
}

Console.Write("Введите размерность массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = createArray(length);
printArray(array);
int[] resultArray = multiplication(array);
Console.WriteLine("Результат:");
printArray(resultArray);