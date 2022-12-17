// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

void fillNumders(int[] array){
	int length = array.Length;
	for(int i = 0; i < length; i++){
		Console.Write($"Введите число №{i+1}: ");
		array[i] = Convert.ToInt32(Console.ReadLine());
	}
};
bool checkTriangle(int[] array){
	bool result = false;
	if(array[0] < array[1] + array[2] && array[1] < array[0] + array[2] && array[2] < array[0] + array[1]) result = true;
	return result;
}

int[] numbers = new int[3];
fillNumders(numbers);
if(checkTriangle(numbers)) Console.WriteLine("Введенные данные могут быть сторонами треугольника");
else Console.WriteLine("Треугольника с такой длинной сторон не может быть");
