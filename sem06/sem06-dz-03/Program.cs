// На вход программы подаются три целых положительных числа. 
// Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, 
// является ли он прямоугольным, равнобедренным, равносторонним.

double[] createNumders(){
	int length = 3;
	double[] array = new double[length];
	string[] letter = new string[3]{"A", "B", "C"};
	for(int i = 0; i < length; i++){
		Console.Write($"Введите длину стороны {letter[i]}: ");
		array[i] = Convert.ToDouble(Console.ReadLine());
	}
	return array;
};

bool checkTriangle(double[] array){
	bool result = false;
	if(array[0] < array[1] + array[2] && array[1] < array[0] + array[2] && array[2] < array[0] + array[1]) result = true;
	return result;
}

int[] copyArray(double[] array){
	int length = array.Length;
	int[] copy = new int[length];
	for (int i = 0; i < length; i++){
		copy[i] = Convert.ToInt32(array[i]);
	}
	return copy;
}

void sortInsertionR(int[] array){
	for(int i = 1; i < array.Length; i++){
		int element = array[i],
			j = i;
		while(j > 0 && array[j-1] < element){
			array[j] = array[j-1];
			j -= 1;
		}
		array[j] = element;
	}
}

void infoTriangle(double[] array){
	double perimeter = 0,
		pp = 0;
	double area;
	int[] sortHypCat = copyArray(array);
	double[] angles = new double[3];
	sortInsertionR(sortHypCat);
	if(array[0] == array[1] && array[0] == array[2]){
		Console.WriteLine("Это равносторонний треугольник");
	}else if(array[0] == array[1] || array[0] == array[2] || array[1] == array[2]){
		Console.WriteLine("Это равнобедренный треугольник");
	}else if(sortHypCat[0]*sortHypCat[0] == sortHypCat[1]*sortHypCat[1] + sortHypCat[2]*sortHypCat[2]){
		Console.WriteLine("Это прямоугольный треугольник");
	}
	foreach (double item in array){ 
		perimeter += item;
	}
	Console.WriteLine($"Периметр = {perimeter}");
	pp = perimeter / 2;
	area = Math.Round(Math.Sqrt(pp * (pp - array[0]) * (pp - array[1]) * (pp - array[2])), 2);
	Console.WriteLine($"Площадь = {area}");
	angles[0] = Math.Round(Math.Acos((array[0]*array[0] + array[2]*array[2] - array[1]*array[1]) / (2 * array[0] * array[2])) * 180 / Math.PI, 2);
	angles[1] = Math.Round(Math.Acos((array[0]*array[0] + array[1]*array[1] - array[2]*array[2]) / (2 * array[0] * array[1])) * 180 / Math.PI, 2);
	angles[2] = Math.Round(Math.Acos((array[1]*array[1] + array[2]*array[2] - array[0]*array[0]) / (2 * array[2] * array[1])) * 180 / Math.PI, 2);
	Console.WriteLine($"Углы: а = {angles[0]},  b = {angles[1]},  с = {angles[2]}");
}

double[] numbers = createNumders();
if(checkTriangle(numbers)){
	Console.WriteLine("\nТакой треугольник существует:");
	infoTriangle(numbers);
}
else {
	Console.WriteLine("Треугольника с такими параметрами не может быть");
}