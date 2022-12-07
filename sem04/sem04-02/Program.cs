// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int multiplication(int number){
	int mult = 1;
	for(int i = 1; i <= number; i++){
		mult = mult*i;
	}
	return mult;
}

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {number} = {multiplication(number)}");