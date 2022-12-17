// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] fillParam(){
	int length = 4;
	double[] array = new double[length];
	string[] param = new string[]{"b1","k1","b2","k2"};
	Console.WriteLine("Введите параметры двух прямых:");
	for(int i = 0; i < length; i++){
		Console.Write($"{param[i]} = ");
		array[i] = Convert.ToDouble(Console.ReadLine());
	}
	return array;
}

string findIntersection(double[] array){
	string result = String.Empty;
	if(array[1] == array[3] && array[0] == array[2]){
		result = "Прямые совпадают";
	}
	else if(array[1] == array[3]){
		result = "Прямые параллельны";
	}
	else{
		double x = Math.Round((array[2] - array[0]) / (array[1] - array[3]), 2);
		double y = Math.Round(array[1] * x + array[0], 2);
		result = "Точка пересечения прямых: ("+x+"; "+y+")";
	}
	return result;
}
try{
	double[] options= fillParam();
	Console.WriteLine(findIntersection(options));

} 
catch{
	Console.WriteLine("Соберись и попробуй еще раз!");
}