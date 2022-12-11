// Напишите программу, которая на вход получает размерность массива. 
// Далее заполняет его случайными уникальными числами и выводит на экран. 
// Далее производим сортировку массива от большего к меньшему и выводим на экран. 
// Далее придумываем алгоритм перемешивания списка на основе случайности , применяем этот алгоритм и выводим на экран результат.

int[] createUnicArray(int length){
	int[] array = new int[length];
	int count = 0;
	while(count < length){
		int number = new Random().Next(0,100);
		bool unic = true;
		for(int i = 0; i < count; i++){
			if(number == array[i]){
				unic = false;
				break;
			}
		}
		if(unic){
			array[count] = number;
			count += 1;
		} 
	}
	return array;
}

void printArray(int[] array){
	foreach(int element in array){
		Console.Write($"{element} ");
	}
	Console.WriteLine("\n");
}

void sortInsertion_rev(int[] array){
	for(int i = 1; i < array.Length; i++){
		int element = array[i],
			j = i;
		while(j > 0 && array[j-1] < element){
			array[j] = array[j-1];
			j -= 1;
		}
		array[j] = element;
	}
}

void shuffling(int[] array){ // Случайный элемент меняем местами с последним, предпоследним и т.д.
	int length = array.Length;
	for(int i = 0; i < length - 1; i++){
		int last = length - 1 - i,
			index = new Random().Next(0, last),
			temp = array[index];
		array[index] = array[last];
		array[last] = temp;
	}
}

Console.Write("Введите размерность массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = createUnicArray(length);
printArray(array);
sortInsertion_rev(array);
Console.WriteLine("Сортировка в обратном порядке:");
printArray(array);
shuffling(array);
Console.WriteLine("Перетасовка:");
printArray(array);