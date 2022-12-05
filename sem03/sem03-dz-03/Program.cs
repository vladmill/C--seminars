// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом.

bool checkPalindrome(ulong number){
	ulong temp = number,
		remainder = 0,
		reverse = 0;
	while(temp > 0){
		remainder = temp % 10;
		temp = temp / 10;
		reverse = reverse * 10 + remainder;
	}
	if(number == reverse) return true;
	else return false;
}
try{
	Console.Write("Введите целое число любой разрядности: ");
	ulong number = Convert.ToUInt64(Console.ReadLine());
	Console.WriteLine();
	bool palindrome = checkPalindrome(number);
	if(palindrome) Console.WriteLine("Число является палиндромом.");
	else Console.WriteLine("Это не палиндромом!");
}
catch{
	Console.WriteLine("Необходимо ввести целое положительное число");
}
