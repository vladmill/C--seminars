// Посчитать сумму всех целых чисел от 1 до N, где N вводится с клавиатуры

Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {N} равна {findSum(N)}");
Console.WriteLine($"Сумма чисел от 1 до {N} равна {findSumRec(N)}");

int findSum(int N){
    int res = 0;
    while(true){ // бесконечный цикл
        res += N;
        N--;
        if(N == 0){
            break;
        }
    }
    return res;
}
int findSumRec(int N){
    if(N == 0) return 0;
    return N + findSumRec(N - 1);
}