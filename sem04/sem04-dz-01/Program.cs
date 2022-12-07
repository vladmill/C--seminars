// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double exponentiate(int numA, int numB){
	double degreeA = numA;
	bool negative = false;
	if(numB == 0) degreeA = 1;
	else if(numB < 0){ 
		numB = -numB; 
		negative = true; 
	} 
	for(int i = 2; i <= numB; i++) degreeA *= numA; 
	if(negative) degreeA = 1 / degreeA;
	return degreeA;
}

Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{numA} в степени {numB} = {exponentiate(numA, numB)}");
