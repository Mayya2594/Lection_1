// Задача 3. Найти факториал числа.

int FactorialFor (int n)
{
    int result = 1;
    for(int i = 1; i <= n; i++) result *= i;
    return result;
}

int FactorialRec (int n)
{
    if (n == 0 || n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

System.Console.WriteLine(FactorialFor(5));
System.Console.WriteLine(FactorialRec(5));