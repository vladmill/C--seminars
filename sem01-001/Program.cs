Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());   // введенное пользователем число приводим к целому
int square = num*num;
//Console.WriteLine("Квадрат ввведенного числа равен "+square);
Console.WriteLine($"Квадрат ввведенного числа равен {square}");

if(num > 9 && num < 100){
	Console.WriteLine("Вы ввели двузначное число");
}
while(num < 25) {
	Console.Write($"{num} ");
	num++;
}
Console.WriteLine();