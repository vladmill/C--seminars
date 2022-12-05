Console.WriteLine("Сколько программистов в комнате?");
int num = Convert.ToInt32(Console.ReadLine());
string declination(int num) {  
	string[] forms = {"программист", "программиста", "программистов"};
	int rem100 = num % 100;
	int rem10 = num % 10;
    if (rem100 > 10 && rem100 < 20) return forms[2];
	else if (rem10 > 1 && rem10 < 5) return forms[1];
    else if (rem10 == 1) return forms[0];
    else return forms[2];
}
Console.Write($"В комнате {num} {declination(num)}");
