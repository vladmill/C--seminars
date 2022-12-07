// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int sumDigits(int number){
	int sumDig = 0;
	if(number < 0) number = -number;
	while(number > 0){
		int endDig = number % 10;
		number = number / 10;
		sumDig += endDig;
	} 
	return sumDig;
}

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр этого числа равна {sumDigits(number)}");