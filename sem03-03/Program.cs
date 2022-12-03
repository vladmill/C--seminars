// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

double squaring (int num){
	double result = Math.Pow(num, 2);
	return result;
}
try{
	Console.Write("Введите целое число: ");
	int number = Convert.ToInt32(Console.ReadLine());
	if(number == 0) Console.WriteLine(0);
	else{
		if(number < 0) number = -1 * number;
		Console.WriteLine($"Квадраты чисел от 1 до {number}:");
		for(int i = 1; i <= number; i++){
			Console.Write($"{squaring(i)} ");
		}
	}
}
catch{
	Console.WriteLine("Ввести нужно целое число!");
}

