// Домашнее задание семинара №1

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// System.Console.WriteLine("Ввведите число N: ");
//  int n = Convert.ToInt32(Console.ReadLine());
//  System.Console.Write($"{n} -> "); 
//  for (int m = 1; m <= n; m++)
//  {
//       if (m % 2 == 0) 
//       {
//         System.Console.Write(m + " "); 
//       }    
//   }

// -------------------------------------------------------------------------
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введите число: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//      Console.Write( $"{n} -> ");
//     if (n % 2 == 0) 
//     {
//       Console.Write("да");  
//     }
//     else
//     {
//      Console.Write("нет");   
//     }

// -------------------------------------------------------------------------
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт
// максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// int max = 0;
// Console.WriteLine("Введите три числа: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());
// Console.Write( $"{a},{b},{c} -> ");
// if(a > max)
// {
//  max = a;
// }
// if(b > max)
// {
//  max = b;
// }
// if(c > max)
// {
//  max = c;
// }
// Console.WriteLine($"{max}");

// --------------------------------------------------------------------------
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите два числа: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write( $"a = {a}; b = {b} ->  ");
// if (a > b)
// {
//   Console.WriteLine($"max = {a}");  
// }
// else
// {
//   Console.WriteLine($"max = {b}");  
// }

