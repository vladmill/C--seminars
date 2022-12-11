// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// Console.Write("Введите размерность массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[length];
// for(int i = 0; i < length; i++){
// 	array[i] = new Random().Next(-9,10);
// }
// int sumP = 0,
// 	sumN = 0;
// foreach (int element in array){
// 	Console.Write($"{element} ");
// 	if(element > 0) sumP += element;
// 	else sumN += element;
// }


int[] createArray(int length){
	int[] array = new int[length];
	for(int i = 0; i < length; i++){
		array[i] = new Random().Next(-9,10);
	}
	return array;
}

void printArray(int[] array){
	foreach (int element in array){
		Console.Write($"{element} ");
	}
	Console.WriteLine();
}

void findSums(int[] array){
	int sumP = 0,
		sumN = 0;
	foreach (int element in array){
		if(element > 0) sumP += element;
		else sumN += element;
	}
	Console.WriteLine($"\nСумма положительных чисел = {sumP}");
	Console.WriteLine($"Сумма отрицательных чисел = {sumN}");
}

int[] findSums2(int[] array){
	int[] result = new int[2];
	foreach (int element in array){
		if(element > 0) result[0] += element;
		else result[1] += element;
	}
	return result;
}

Console.Write("Введите размерность массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = createArray(length);
printArray(array);
findSums(array);
int[] results = findSums2(array);
Console.WriteLine($"\nСумма положительных чисел = {results[0]}");
Console.WriteLine($"Сумма отрицательных чисел = {results[1]}");