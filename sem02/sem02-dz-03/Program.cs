Console.WriteLine("Введите номер дня недели");
int num = Convert.ToInt32(Console.ReadLine());
string[] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
if(num > 0 && num < 8){
	if(num < 6) Console.WriteLine($"{days[num-1]} - рабочий день");
	else Console.WriteLine($"Ура! {days[num-1]} выходной");
}else{
	Console.WriteLine("В неделе семь дней. Нужно ввести число от 1 до 7");
}
