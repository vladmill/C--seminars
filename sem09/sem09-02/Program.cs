// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

string findNumbers(int M, int N){
    if(N == M) return ""+N+"";
    return findNumbers(M, N-1) +", "+N;
}

Console.WriteLine("Введите крайние значения промежутка: ");
Console.Write("от: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("до: ");
int N = Convert.ToInt32(Console.ReadLine());
if(M > N) (M, N) = (N, M);
Console.WriteLine($"Все натуральные числа от {M} до {N}:");
Console.WriteLine($"{findNumbers(M, N)} ");