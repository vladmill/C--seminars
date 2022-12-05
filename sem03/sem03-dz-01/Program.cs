// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int cube (int num){
	int result = num*num*num;
	return result;
}
try{
	Console.Write("Введите целое положительное число: ");
	int number = Convert.ToInt32(Console.ReadLine());
	if(number == 0) Console.WriteLine(0);
	else if(number < 0) Console.WriteLine("По условию задачи число должно быть положительным.");
	else{
		Console.WriteLine($"Кубы чисел от 1 до {number}:");
		for(int i = 1; i <= number; i++){
			Console.Write($"{cube(i)} ");
		}
	}
}
catch{
	Console.WriteLine("Ввести нужно целое положительное число.");
}