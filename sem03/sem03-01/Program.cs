// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

string checkСoord(int num){
	string result = string.Empty;
	if(num == 1) result = "Координаты точек в этой четверти: x > 0 и y > 0";
	else if(num == 2) result = "Координаты точек в этой четверти: x < 0 и y > 0";
	else if(num == 3) result = "Координаты точек в этой четверти: x < 0 и y < 0";
	else if(num == 4) result = "Координаты точек в этой четверти: x > 0 и y < 0";
	else result = "Четверти нумеруются от 1 до 4";
	return result;
}
try{
	Console.Write("Введите номер четверти: ");
	int number = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine(checkСoord(number));
}
catch {
	Console.WriteLine("Необходимо ввести целое число от 1 до 4");
}