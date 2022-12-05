Console.WriteLine("введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Третья цифра введенного числа {num % 10}");