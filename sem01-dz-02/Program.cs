Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if(max < num2){
	max = num2;
}else if(max < num3){
	max = num3;
}
Console.WriteLine($"Максимальное из введённых чисел {max}");