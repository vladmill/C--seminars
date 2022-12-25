// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int sumDigit(int N){
    if(N == 0) return 0;
    return N % 10 + sumDigit(N / 10);
}

Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр {N} равна {sumDigit(N)}");