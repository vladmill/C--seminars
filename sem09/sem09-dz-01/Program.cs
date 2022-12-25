// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string createStrNum(int N){
    if(N == 1) return "1";
    return N + ", "+ createStrNum(N-1);
}

Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Все натуральные числа от {N} до 1:");
Console.WriteLine($"{createStrNum(N)} ");