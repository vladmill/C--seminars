int num = new Random().Next(100,1000);
Console.WriteLine($"Сгенерировано случайное трехзначное число {num}");
int x1 = num/100;
int x3 = num%10;
Console.WriteLine($"После удаления второй цифры получается {x1}{x3}");