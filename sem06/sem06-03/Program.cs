// Задача 44: Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1

int[] fibonacci(int num){
	int[] fib = new int[num];
	for(int i = 0; i < num; i++){
		if(i < 2){
			fib[i] = i;
		}else{
			fib[i] = fib[i-2] + fib[i-1];
		}
	}
	return fib;
}
void printArray(int[] array){
	foreach(int element in array){
		Console.Write($"{element} ");
	}
	Console.WriteLine("\n");
}

Console.Write("Сколько чисел ряда Фибоначчи вывести: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] numbersFib = fibonacci(number);
printArray(numbersFib);

