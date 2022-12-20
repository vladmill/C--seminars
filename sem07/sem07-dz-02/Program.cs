// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.

void printArray(int[,] array){
	Console.WriteLine();
	for (int i = 0; i < array.GetLength(0); i++){
		for (int j = 0; j < array.GetLength(1); j++){
			Console.Write($"{array[i,j],2}\t");
		}
		Console.WriteLine("\n");
	}
}

void fillArray(int[,] array){
	for (int i = 0; i < array.GetLength(0); i++){
		for (int j = 0; j < array.GetLength(1); j++){
			array[i, j] = new Random().Next(1, 21);
		}
	}
}

string findNumber(int[,]array, int number){
	string message = String.Empty;
	bool flag = false;
	for (int i = 0; i < array.GetLength(0); i++){
		for (int j = 0; j < array.GetLength(1); j++){
			if(array[i, j] == number){
				message = "Индекс элемента с искомым значением: ["+i+", "+j+"]";
				flag = true;
				break;
			}
			array[i, j] = new Random().Next(1, 21);
		}
		if(flag) break;
	}
	if(!flag) message = "Нет такого значения в массиве.";
	return message;
}

Console.Write("Введите число от 1 до 20: ");
int number = Convert.ToInt32(Console.ReadLine()); 
int[,] array = new int[5, 5];
fillArray(array);
printArray(array);
Console.WriteLine(findNumber(array, number));
