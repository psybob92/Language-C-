

/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */


// void PrintN(int N)
// {
//     if (N > 0)
//     {
//         System.Console.Write($"{N} ");
//         PrintN(N - 1);
//     }
// }
// System.Console.Write("N -> ");
// PrintN(8);


// =============================================================

﻿// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int GetSumRange(int m, int n)
// {
//     int min = m > n ? n : m;
//     int max = m > n ? m : n;
//     if (min < max)
//     {
//         return GetSumRange(min, max - 1) + max;
//     }
//     else if (min == max)
//         return min;
//     else
//         return 0;
// }

// int m = 1;
// int n = 15;
// System.Console.WriteLine($"M = {m}; N = {n} -> {GetSumRange(m, n)}");
// m = 4;
// n = 8;
// System.Console.WriteLine($"M = {m}; N = {n} -> {GetSumRange(m, n)}");

// =============================================================================


﻿// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//


// int Ackerman(int n, int m)
// {
//     if (n == 0)
//         return m + 1;
//     else if (m == 0)
//         return Ackerman(n - 1, 1);
//     else
//         return Ackerman(n - 1, Ackerman(n, m - 1));
// }

// int n = 2;
// int m = 3;
// System.Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Ackerman(n, m)}");
// n = 3;
// m = 2;
// System.Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Ackerman(n, m)}");