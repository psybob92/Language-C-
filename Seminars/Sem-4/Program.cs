// Напишите программу, которая принимает не вход число и выдает количество цифр  в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int DigitCount(int num)
// {
//     int count = 0;
//     for(int i = 1; Math.Abs(num) > 0; i++)
//     {
//         // num = num / 10; 
//         num /= 10;
//         count = i;
//     }
//     return count;
// }

// System.Console.Write("input num: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(DigitCount(num));

// >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


// Напишите программу которая выводит массив из n элементов, заполненный 
// рандомными значениями в указанном диапазоне, в случайном порядке.

// [1,0,1,1,0,1,0,0]


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//    int[] array = new int[size];
//    for(int i = 0; i < size; i++)
//    {
//      array[i] = new Random().Next(minValue, maxValue + 1); 
//    }
//    return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }

// System.Console.Write("input size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("input min value: ");
// int min = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("input max value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// PrintArray(CreateRandomArray(size, min, max));

// >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


// Напишите программу, которая принимает на вход число (А) и выдает
// сумму чисел от 1 до А и факториал числа (А).

// 7 -> 28
// 4 -> 10
// 8 -> 36

// int GetSumNumbers(int num)
// {
//     int sum = 0;
//     for(int i = 1; i <= num; i++)
//     {
//       sum += i;
//     }
//     return sum;
// }

// int FindFactorial(int num)
// {
//     int fakt = 1;
//     for(int i = 1; i <= num; i++)
//     {
//       fakt *= i;
//     }
//     return fakt;
// }

// System.Console.Write("Введите число А: ");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Сумма -> {GetSumNumbers(a)}");
// System.Console.WriteLine($"Факториал -> {FindFactorial(a)}");