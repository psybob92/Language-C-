// Написать программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным.

// 34, 5 -> не кратно, остаток 4
//  16, 4 -> кратно
// ---------------------------------------

// (после команды идет название метода, которое придумываем сами)
// void CheckMultiplicity(int num1, int num2)
// {
//    if(num1 % num2 == 0)
//    {
//     System.Console.WriteLine($"{num1}, {num2} -> кратно");
//    }
//    else
//    {
//     System.Console.WriteLine($"{num1}, {num2} ->  не кратно, остаток {num1 % num2}");
//    }
// }

// System.Console.Write("input first number: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("input second number: ");
// int n2 = Convert.ToInt32(Console.ReadLine());

// 

// >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

// Напишите программу, которая выводит случайное число из отрезка [10. 99] 
// и показывает наибольшую цифру.

//  78 -> 8
//  12 -> 2
//  85 -> 8
// ------------------------------------------------

// int BiggestDigit(int num)
// {
//    int ed = num % 10;
//    int dec = num / 10;
//    if(ed > dec)
//    {
//     return ed;
//    }
//    else
//    {
//      return dec;
//    }
// }

// int num = new Random().Next(10, 99 + 1);
// System.Console.Write($"{num} -> ");
// System.Console.WriteLine(BiggestDigit(num));

// >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

// Написать программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
// -----------------------------------------------------------

// void ExampleMetod(int num)
// {
//     int ed = num % 10;
//     int hand = num / 100;
//     System.Console.WriteLine($"{num} -> {hand * 10 + ed}");
// }
// int num = new Random().Next(100, 1000);
// ExampleMetod(num);

// >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

// Написать програму, которая принимает на вход число и
//  проверяет кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
// -----------------------------------------------------------

// bool CheckMultiplicity(int num)
// {
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//       return true;  
//     }
//     else
//     {
//       return false;
//     }
// }
// System.Console.WriteLine("input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"{num} -> {CheckMultiplicity(num)}");