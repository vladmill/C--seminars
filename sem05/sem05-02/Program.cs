// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] createArray(int length){
	int[] array = new int[length];
	for(int i = 0; i < length; i++){
		array[i] = new Random().Next(-9,10);
	}
	return array;
}

void printArray(int[] array){
	foreach(int element in array){
		Console.Write($"{element} ");
	}
	Console.WriteLine();
}

bool findNumber(int[] array, int number){
	bool result = false;
	foreach(int element in array){
		if(element == number){
			result = true; 
			break;
		}
	}
	return result;
}

Console.Write("Введите размерность массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = createArray(length);
printArray(array);
Console.Write("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = findNumber(array, number);
if(result) Console.WriteLine("Есть такое число в массиве");
else Console.WriteLine("Такого числа в массиве нет");