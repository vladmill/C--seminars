Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int numStart = num * (-1);
while(numStart <= num){
	Console.Write($"{numStart}, ");
	numStart++;
}
