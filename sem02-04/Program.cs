// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num1*num1 == num2){
// 	Console.WriteLine($"Да, квадрат {num1} равен {num2}");
// }else if(num2*num2 == num1){
// 	Console.WriteLine($"Да, квадрат {num2} равен {num1}");
// }else{
// 	Console.WriteLine($"Нет, одно число не является квадратом другого");
// }

int size = 6;
int[] numbs = new int[size];
for(int i = 0; i < size; i++){
	Console.WriteLine($"Введите {i+1} число");
	numbs[i] = Convert.ToInt32(Console.ReadLine());
}
for(int i = 0; i < size; i++){
	for(int j = 0; j < size; j++){
		if(numbs[i] == numbs[j]*numbs[j]) Console.WriteLine($"Число {i+1} является квадратом числа {j+1}");
	}
}
