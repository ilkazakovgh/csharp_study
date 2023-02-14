//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int getSecondDigit(int num) {
//     return (num % 100) / 10;
// }

// Console.Write("Input a three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int secondDigit = getSecondDigit(num);
// Console.WriteLine($"Second digit is: {secondDigit}");

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int getThirdDigit(int num) {
//     if (num < 100)
//         return -1;
//     else    
//         return (num % 1000) / 100;
// }

// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int thirdDigit = getThirdDigit(num);
// if (thirdDigit > -1)
//     Console.WriteLine($"Third digit is: {thirdDigit}");
// else    
//     Console.WriteLine($"There is no third digit");

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// bool isHoliday(int dayNumber) {
//     return (dayNumber == 6 || dayNumber == 7);
// }

// Console.Write("Input a day number: ");
// int dayNum = Convert.ToInt32(Console.ReadLine());
// if (isHoliday(dayNum))
//     Console.WriteLine("It's a holiday");
// else    
//     Console.WriteLine("It's not a holiday");
