﻿// Задача 4. Вычислить а в степени n.

int PowerFor(int a, int n)
{
    int result = 1;
    for(int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec (int a, int n)
{   // тернарный оператор: return n == 0 ? 1 : PowerRec(a, n- 1) * a;
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

int PowerRecMath (int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n -1) * a;
}

System.Console.WriteLine(PowerFor(2, 10));
System.Console.WriteLine(PowerRec(2, 10));
System.Console.WriteLine(PowerRecMath(2, 10));