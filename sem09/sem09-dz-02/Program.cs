// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int sumMtoN(int M, int N){
    if(N == M) return M;
    return N + sumMtoN(M, N - 1);
}

Console.WriteLine("Задайте промежуток");
Console.Write("от: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("до: ");
int N = Convert.ToInt32(Console.ReadLine());
if(M > N) (M, N) = (N, M);
Console.WriteLine($"Сумма натуральных элементов от {M} до {N} равна {sumMtoN(M, N)}");
