Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 2){
	Console.WriteLine("Попробуйте еще раз, с числом больше 1");
}else{
	// int count = 2;
	// while(count <= num){
	// 	Console.Write($"{count} ");
	// 	count = count + 2;
	// }
	int count = 1;
	while(count <= num){
		if(count % 2 == 0){
			Console.Write($"{count} ");
		}
		count++;
	}
}