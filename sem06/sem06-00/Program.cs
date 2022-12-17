// Отразить зеркально одномерный массив.

void fillArray(int[] array){
	int length = array.Length;
	for(int i = 0; i < length; i++){
		array[i] = new Random().Next(-20,21);
	}
}

void printArray(int[] array){
	foreach(int element in array){
		Console.Write($"{element} ");
	}
	Console.WriteLine("\n");
}

void reverse(int[] array){
	int length = array.Length,
		last = length - 1,
		temp;
	for( int i = 0; i < length/2; i++){
		temp = array[i];
		array[i] = array[last-i];
		array[last-i] = temp;
	}
}

int[] array = new int[11];
fillArray(array);
printArray(array);
reverse(array);
printArray(array);
