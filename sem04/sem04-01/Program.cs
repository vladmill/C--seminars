// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int countNum(int number){
	int count = 0;
	while(number > 0){
		number = number / 10;
		count += 1;
	} 
	return count;
}

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"количество цифр в числе = {countNum(number)}");