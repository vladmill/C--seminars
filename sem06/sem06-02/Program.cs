// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

string convertNumber(int num){
	string result = String.Empty;
	while(num > 0){
		result = Convert.ToString(num % 2) + result; // дописываем слева!
		num = num / 2;
	}
	return result;
}

// А по теме урока надо было бы записывать остаток от деления в массив, потом его зеркалить и выводить.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"В двоичной системе {number} = {convertNumber(number)}");