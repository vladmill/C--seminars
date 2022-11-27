Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
int squareNum2 = num2*num2;
if(squareNum2 == num1){
	Console.WriteLine("Первое число является квадратом второго");
}else{
	Console.WriteLine("Первое число не является квадратом второго");
}