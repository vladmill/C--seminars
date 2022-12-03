Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int remainder7 = num % 7;
int remainder23 = num % 23;
if(remainder7 == 0 && remainder23 == 0) {
	Console.WriteLine("Ура! число кратно 7 и 23");
}else if(remainder7 == 0  && remainder23 != 0) {
	Console.WriteLine("Число кратно 7, но не кратно 23 (");
}else if(remainder7 != 0  && remainder23 == 0) {
	Console.WriteLine("Число кратно 23, но не кратно 7 (");
}else {
	Console.WriteLine("Число не кратно ни 7, ни 23 (((");
}