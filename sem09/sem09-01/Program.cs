// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string findNumbers(int N){
    if(N == 1) return "1";
    return findNumbers(N-1) +", "+N;
}

Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Все натуральные числа от 1 до {N}:");
Console.WriteLine($"{findNumbers(N)} ");