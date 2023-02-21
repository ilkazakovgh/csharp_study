// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// int getDigitAtPosition(int num, int position) {
//     //75968 - число
//     //43210 - позиции справа налево, начиная с 0
//      return (num / Convert.ToInt32(Math.Pow(10, position))) % 10;
// }

// int getDigitsCount(int num) {
//     int result = 0;
//     if (num == 0) 
//         result = 1;    
//     while (num > 0) {
//         num = num / 10;
//         result++;
//     }

//     return result;
// }

// bool isPolyndrom(int num) {
//     bool result = (num > 10);
//     int digitsCount = getDigitsCount(num);
//     int currentDigitNum = 0;
//     while ((currentDigitNum < digitsCount / 2) && result) {
//         result = result && (getDigitAtPosition(num, currentDigitNum) == getDigitAtPosition(num, digitsCount - currentDigitNum - 1));
//         currentDigitNum++;
//     }
//     return result;
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (isPolyndrom(num))
//     Console.WriteLine("Число является полиндромом.");
// else    
//     Console.WriteLine("Число не является полиндромом.");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double getDistance3D(double xa, double ya, double xb, double yb, double za, double zb) {
//     return Math.Round(Math.Sqrt((xb-xa)*(xb-xa) + (yb-ya)*(yb-ya) + (zb-za)*(zb-za)), 2);
// }

// Console.Write("Введите координату X первой точки: ");
// double xa  = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y первой точки: ");
// double ya  = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Z первой точки: ");
// double za  = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координату X второй точки: ");
// double xb  = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y второй точки: ");
// double yb  = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Z второй точки: ");
// double zb  = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Расстояние между точками в 3D пространстве: " + getDistance3D(xa, ya, xb, yb, za, zb));


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void printCubeTable(int num) {
//     for(int i = 1; i <= num; i++) {
//         Console.Write(Math.Pow(i, 3));
//         if (i < num)
//             Console.Write(", ");
//     }
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// printCubeTable(num);
