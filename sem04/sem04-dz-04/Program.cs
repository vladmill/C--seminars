// Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.

int toInteger(decimal num){
	if(num < 0) num = -num;
	decimal endDig = -1;
	while(endDig != 0){
		num = num * 10;
		endDig = num % 10;
	}
	return Convert.ToInt32(num / 10);
}

int countDigits(int num){
	int count = 0;
	while(num > 0){
		num = num / 10;
		count += 1;
	} 
	return count;
}

try {
	Console.WriteLine("Введите любое число:");
	decimal number = Convert.ToDecimal(Console.ReadLine());
	Console.WriteLine($"Количество цифр в вашем числе равно {countDigits(toInteger(number))}");
}
catch {
	Console.WriteLine("Что-то пошло не так. Возможно вы ввели число через '.', попробуйте через ','");
}
