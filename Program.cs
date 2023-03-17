﻿using static System.Console;

int results = Fibonacci(5);
WriteLine(results);

static int Fibonacci(int n)
{
    int n1 = 0;
    int n2 = 2;
    int sum;

    for (int i = 2; i < n; i++)
    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
    }
    return n == 0 ? n1 : n2;
}

