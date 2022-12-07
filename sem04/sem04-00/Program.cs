// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// Console.Write("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine()),
// 	sum = 0;
// for(int i = 1; i <= num; i++) sum += i;
// Console.WriteLine($"Сумма всех чисел от 1 до {num} равна {sum}");

int sumNumbers(int num){
	int sum = 0;
	for(int i = 1; i <= num; i++) sum += i;
	return sum;
}

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма всех чисел от 1 до {num} равна {sumNumbers(num)}");