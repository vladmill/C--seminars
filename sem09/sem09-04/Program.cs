// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int degreeAtoB(int a, int b){
    if(b == 1) return a;
    return a * degreeAtoB(a, b - 1);
}

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a} в степени {b} = {degreeAtoB(a, b)}");