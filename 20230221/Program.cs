//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// double Pow(int a, int pow) {
//     double res = a;
//     for(int i = 1; i < pow; i++)
//         res *= a;

//     return res;    
// }

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень: ");
// int pow = Convert.ToInt32(Console.ReadLine());
// double aPowb = Pow(a, pow);
// Console.WriteLine($"{a}^{pow} = {aPowb}");

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int GetDigitAtPosition(int num, int position) {
//     //75968 - число
//     //43210 - позиции справа налево, начиная с 0
//      return (num / Convert.ToInt32(Math.Pow(10, position))) % 10;
// }

// int GetDigitsCount(int num) {
//     int result = 0;
//     if (num == 0) 
//         result = 1;    
//     while (num > 0) {
//         num = num / 10;
//         result++;
//     }

//     return result;
// }

// int GetDigitsSum(int num) {
//     int result = 0;
//     int digitsCount = GetDigitsCount(num);
//     for(int i = 0; i < digitsCount; i++)
//         result += GetDigitAtPosition(num, i);
//     return result;
// }

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Сумма цифр числа: " + GetDigitsSum(a));

//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// int[] CreateRandomArray(int size, int minValue, int maxValue) {
//     int[] result = new int[size];

//     for(int i = 0; i < size; i++) 
//         result[i] = new Random().Next(minValue, maxValue + 1);
    
//     return result;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// Console.Write("Введите количество элементов в массиве: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(m, 10, 20);
// ShowArray(array);
