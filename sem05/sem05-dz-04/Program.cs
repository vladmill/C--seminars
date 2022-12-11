// Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

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

double[] findMinMaxAverage(int[] array){
	double[] result = new double[5]{0, array[0], 0, array[0], 0};
	int length = array.Length;
	for(int i = 0; i < length; i++){
		if(array[i] < result[1]){
			result[0] = i;
			result[1] = array[i];
		}else if(array[i] > result[3]){
			result[2] = i;
			result[3] = array[i];
		}
		result[4] += array[i];
	}
	result[4] = Math.Round(result[4] / length, 2);
	return result;
}

void sortBubble(int[] array){
	int length = array.Length;
	for(int i = 0; i < length; i++){
		for(int j = 0; j < length - 1 - i; j++){
			if(array[j] > array[j+1]){
				int temp = array[j];
				array[j] = array[j+1];
				array[j+1] = temp;
			}
		}
	}
}

double findMedian(int[] array){
	sortBubble(array);
	int length = array.Length,
		half = length / 2;
	double median = array[half];
	if(length % 2 == 0)	median = Math.Round((median + array[half - 1]) / 2, 2);
	return median;
}

Console.Write("Введите размерность массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = createArray(length);
printArray(array);
double[] resultMMA = findMinMaxAverage(array);
Console.WriteLine($"Минимальный элемент [{resultMMA[0]}] = {resultMMA[1]}");
Console.WriteLine($"Максимальный элемент [{resultMMA[2]}] = {resultMMA[3]}");
Console.WriteLine($"Среднее арифметическое = {resultMMA[4]}");
Console.WriteLine($"Медианное значение = {findMedian(array)}");
