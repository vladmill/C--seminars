// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. 
// Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.

int[] generateArray(int length){
	int[] array = new int[length];
	for(int i = 0; i < length; i++)
		array[i] = new Random().Next(0,2);
	return array;
}

void printArray(int[] array, int length){
	Console.Write("Ваш массив: [");
	for(int i = 0; i < length; i++){
		if(i == 0) Console.Write(array[i]);
		Console.Write($", {array[i]}");
	}
	Console.Write($"] = {checkArray(array, length)}");
}

bool checkArray(int[] array, int length){
	int quantity_1 = 0,
		quantity_0 = 0;
	bool check = false;
	for(int i = 0; i < length; i++){
		if(array[i] > 0) quantity_1 += 1;
		else quantity_0 += 1;	
	}
	if(quantity_1 > quantity_0) check = true;
	return check;
}

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = generateArray(length);
printArray(array, length);
