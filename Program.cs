// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int SumNumbers (int m, int n)
{
    if (m == n) return n;
    else return m + SumNumbers(m + 1, n);
}

int InputNumber(string str)
{
    Console.Write($"Input number {str}: ");
    return Convert.ToInt32(Console.ReadLine());
}

Console.Write($"Sum of elements: {SumNumbers(InputNumber("m"), InputNumber("n"))}");
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

/*
double AckermannFunction (double m, double n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermannFunction (m - 1, 1);
    if (m > 0 && n > 0) return AckermannFunction (m - 1, AckermannFunction (m, n - 1));
    return 0;
} 

double InputNumber(string str)
{
    Console.Write($"Input number {str}: ");
    return Convert.ToDouble(Console.ReadLine());
}

Console.Write($"Value Ackermann Function: {AckermannFunction(InputNumber("m"), InputNumber("n"))}");
*/