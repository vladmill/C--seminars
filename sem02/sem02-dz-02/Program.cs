Console.Clear();
// int num = new Random().Next();
// Console.WriteLine($"случайное число любой разрядности {num}");
Console.WriteLine("Введите число любой разрядности");
int num = Convert.ToInt32(Console.ReadLine());
int digit = -1;
while(num > 99){
	digit = num % 10;
	num = num/10;
}
if( digit == -1){
	Console.Write($"Введённое число меньше 100");
}else{
	Console.Write($"Третья цифра введённого числа {digit}");
}
