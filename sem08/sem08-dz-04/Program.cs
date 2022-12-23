// Задача 60. Сформируйте трёхмерный массив из неповторяющихся (HARD - случайных уникальных) двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void printCube(int[,,] cube){
    Console.WriteLine();
	for(int i = 0; i < cube.GetLength(0); i++){
		for(int j = 0; j < cube.GetLength(1); j++){
            for(int k = 0; k < cube.GetLength(2); k++){
                Console.Write($"{cube[i, j, k]}[{i},{j},{k}]\t");
            }
            Console.WriteLine();
		}
	}
}

int randomUnicNumber(int[,,] cube){
	int number = new Random().Next(10, 100);
	for (int i = 0; i < cube.GetLength(0); i++){
		for (int j = 0; j < cube.GetLength(1); j++){
            for (int k = 0; k < cube.GetLength(2); k++){
                if(cube[i, j, k] == number){
                    return randomUnicNumber(cube);
                }
            }
		}
	}
	return number;
}

void fillCube(int[,,] cube){
	for (int i = 0; i < cube.GetLength(0); i++){
		for (int j = 0; j < cube.GetLength(1); j++){
            for (int k = 0; k < cube.GetLength(2); k++){
                cube[i, j, k] = randomUnicNumber(cube);
            }
		}
	}
}

int[,,] createCube(){
	Console.WriteLine("Введите параметры куба:");
	Console.Write("длина по X: ");
	int x = Convert.ToInt32(Console.ReadLine());
	Console.Write("длина по Y: ");
	int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("длина по Z: ");
	int z = Convert.ToInt32(Console.ReadLine());
    if(x * y * z > 90){ // кол-во уникальных двузначных чисел
        Console.WriteLine("Куб слишком большой. Попробуйте еще раз.");
        return createCube();
    }else{
        int[,,] cube = new int[z, x, y];
        return cube;
    }
}

int[,,] cube = createCube();
fillCube(cube);
printCube(cube);
