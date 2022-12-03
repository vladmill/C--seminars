Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
int remainder = num1 % num2;
if(remainder == 0) Console.WriteLine($"{num1} кратно {num2}");
else Console.WriteLine($"{num1} не кратно {num2}, остаток {remainder}");