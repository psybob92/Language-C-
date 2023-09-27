// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int number = Prompt("Введите трехзначное число: ");
// if (number < 100 || number >= 1000)
// {
//     System.Console.WriteLine("Ой,а вы ввели не трехзначное число, попробуйте еще раз!");
//     return;
// }

// System.Console.Write($"Здорово! В вашем числе {number} -> ");
// int secondDigit = number / 10 % 10;
// System.Console.WriteLine($"{secondDigit} - вторая цифра!");


// ----------------------------------------------------------------------------------
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int ThirdDigit(int number)
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     return number % 10;
// }

// bool ValidateNumber(int number)
// {
//     if (number < 100)
//     {
//         System.Console.WriteLine("Третьей цифры нет");
//         return false;
//     }
//     return true;
// }

// int number = Prompt("Введите число:  ");
// if(ValidateNumber(number))
// {
//     System.Console.WriteLine(ThirdDigit(number));
// }

// ----------------------------------------------------------------------------
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// bool Weekend(int weekDay)
// {
//     if (weekDay > 5)
//     {
//         return true;
//     }
//     return false;
// }

// bool ValiWeekend(int number)
// {
//     if (number > 0 && number <= 7)
//     {
//         return true;
//     }
//     System.Console.WriteLine("Нет такого дня недели!");
//     return false;
// }

// int weekDay = Prompt("Введите день недели:  ");
// if (ValiWeekend(weekDay))
// {
//     if (Weekend(weekDay))
//     {
//         System.Console.WriteLine("Это выходной:  ");
//     }
//     else
//     {
//        System.Console.WriteLine("Рабочий день:  "); 
//     }
    
// }
