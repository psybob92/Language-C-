// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string readInput = System.Console.ReadLine();
//     int result = int.Parse(readInput);
//     return result;
// }

// int Rais(int num1, int num2)
// {
//    int rais = 1;
//     for(int i = 0; i < num2; i++)
//     {
//       rais *= num1; 
//     }
//     return rais;
// }

// bool Exception(int num2)
// {
//     if (num2 <= 0)
//     {
//     System.Console.WriteLine("число В не может быть меньше нуля");
//     return false;
//     }
//     return true;
// }
// int num1 = Prompt("Введите число А: ");
// int num2 = Prompt("Введите число B: ");
// if (Exception(num2))
// {
//    System.Console.WriteLine($"{num1}, {num2} -> {Rais(num1, num2)}"); 
// }
// --------------------------------------------------------------------------------------

// Задача 1: Мой, рабочий вариант.

// int Rais(int a, int b)
// {
//    int rais = 1;
//     for(int i = 0; i < b; i++)
//     {
//       rais *= a; 
//     }
//     return rais;
// }

// bool Exception(int b)
// {
//     if (b <= 0)
//     {
//     System.Console.WriteLine("Ты шутишь? Число (B) не может быть меньше или равно нулю!");
//     return false;
//     } 
//     return true;      
// }

// System.Console.Write("Введите число А: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (Exception(b))
// {
//  System.Console.WriteLine($"Число {a} возведенное в {b} степень равно: {Rais(a, b)}"); 
// }

// >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// ---------------------------------------------------------
// int Prompt(string message)
//       {
//         System.Console.Write(message);
//         string readInput = System.Console.ReadLine();
//         int result = int.Parse(readInput);
//         return result;
//       }

//  int SumAllDigit(int number)
//  {
//     int result = 0;
//     while (number > 0)
//     {
//         result += number % 10;
//         number = number / 10;
//         // result = number / 10 + number % 10 + number % 10;
//     }
//     return result;
//  }

// int number = Prompt("Введите число:");
// System.Console.WriteLine($"Сумма всех чисел в цифре {number} = {SumAllDigit(number)}");

// ------------------------------------------------------------------------

// int SumAllDigit(int number)
//  {
//     int result = 0;
//     while (number > 0)
//     {
//         result += number % 10;
//         number = number / 10;

//     }
//     return result;
//  }
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Сумма всех цифр {number} = {SumAllDigit(number)}");

// >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// ----------------------------------------------------------------------

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string readInput = System.Console.ReadLine();
//     int result = int.Parse(readInput);
//     return result;
// }

// int[] GenerateArray(int Length, int minValue, int maxValue)
// {
//     int[] array = new int[Length];
//     Random random = new Random();
//     for (int i = 0; i < Length; i++)
//     {
//         array[i] = random.Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write($"{array[array.Length - 1]}");
//     Console.WriteLine("]");
// }
// int Length = Prompt("Длина масива: ");
// int min = Prompt("Начало случайного масива: ");
// int max = Prompt("Конец случайного масива: ");
// int[] array = GenerateArray(Length, min, max);

// PrintArray(array);
