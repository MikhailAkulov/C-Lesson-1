// Рекурсия на примере вычисления факториала

double Factorial(int n) // double используется потому что тип int не в мещает в себя необходимое количество знаков
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}