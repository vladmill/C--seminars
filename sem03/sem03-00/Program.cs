// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите координату X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y");
// int y = Convert.ToInt32(Console.ReadLine());

// if(x > 0 && y > 0) Console.WriteLine("Это четверть № 1");
// else if(x > 0 && y < 0) Console.WriteLine("Это четверть № 4");
// else if(x < 0 && y > 0) Console.WriteLine("Это четверть № 2");
// else if(x < 0 && y < 0) Console.WriteLine("Это четверть № 3");
// else Console.WriteLine("Точка находится на координатной оси");

void checkСoord(int x, int y){
	if(x > 0 && y > 0) Console.WriteLine("Это четверть № 1");
	else if(x > 0 && y < 0) Console.WriteLine("Это четверть № 4");
	else if(x < 0 && y > 0) Console.WriteLine("Это четверть № 2");
	else if(x < 0 && y < 0) Console.WriteLine("Это четверть № 3");
	else Console.WriteLine("Точка находится на координатной оси");
}

string checkСoord2(int x, int y){
	string result = string.Empty;
	if(x > 0 && y > 0) result = "Это четверть № 1";
	else if(x > 0 && y < 0) result = "Это четверть № 4";
	else if(x < 0 && y > 0) result = "Это четверть № 2";
	else if(x < 0 && y < 0) result = "Это четверть № 3";
	else result = "Точка находится на координатной оси";
	return result;
}

try{
	Console.WriteLine("Введите координату X");
	int x = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Введите координату Y");
	int y = Convert.ToInt32(Console.ReadLine());
	checkСoord(x, y);
	Console.WriteLine(checkСoord2(x, y));
}
catch {
	Console.WriteLine("Необходимо вводить целые числа");
}