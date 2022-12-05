Console.Clear();
// Console.WriteLine("Введите трёхзначное число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// лень каждый раз вводить, плюс проверку на трёхзначность придётся делать, поэтому Random))

int num = new Random().Next(100,1000);
Console.WriteLine($"случайное трёхзначное число {num}");
int x2 = num / 10 % 10;
Console.WriteLine($"Вторая цифра этого числа {x2}");
