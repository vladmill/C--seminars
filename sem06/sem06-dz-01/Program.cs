// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь

int[] fillNumders(int length){
	int[] array = new int[length];
	for(int i = 0; i < length; i++){
		Console.Write($"Введите число №{i+1}: ");
		array[i] = Convert.ToInt32(Console.ReadLine());
	}
	return array;
}

int countPosNum(int[] array){
	int result = 0;
	foreach (int item in array){
		if(item > 0) result += 1;
	}
	return result;
}

try{
	Console.Write("Сколько чисел хотите ввести: ");
	int length = Convert.ToInt32(Console.ReadLine());
	int[] numbers = fillNumders(length);
	Console.WriteLine($"Количество положительных чисел: {countPosNum(numbers)}");
} 
catch{
	Console.WriteLine("Соберись и попробуй еще раз!");
}
