// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] generateArray(int length){
	int[] array = new int[length];
	for(int i = 0; i < length; i++)
		array[i] = new Random().Next(0,2);
	return array;
}

void writeArray(int[] gArray, int length){
	for(int i = 0; i < length; i++) Console.Write($"{gArray[i]} ");	
}

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
writeArray(generateArray(length), length);
