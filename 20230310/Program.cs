//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

// void ShowNums(int num) 
// {
//     Console.Write($"{num} ");
//     if (num > 1)
//         ShowNums(num - 1);
// }

// Console.Write("Введите натуральное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 0) 
//     ShowNums(num);
// else
//     Console.WriteLine($"{num} - не натуральное число");

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int SumNums(int m, int n) 
// {
//     if (m > n)
//         return m + SumNums(m - 1, n);
//     else if (m < n)
//         return m + SumNums(m + 1, n);
//     else    
//         return n;    
// }

// Console.Write("Введите натуральное число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите натуральное число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (m > 0 && n >0) {
//     int sum = SumNums(m, n);
//     Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n}: {sum}");
// } else {
//     Console.WriteLine("Числа m и n должны быть натуральными.");
// } 

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int ack(int n, int m)
// {
//     if (n == 0)
//         return m + 1;
//     else if (m == 0)
//         return ack(n - 1, 1);
//     else
//         return ack(n - 1, ack(n, m - 1));       
// }

// int ackIterative(int n, int m)
// {
//     while (n != 0) {
//         if (m == 0)
//             m = 1;
//         else 
//             m = ack(n, m - 1);
//         n--;        
//     }
//     return m + 1;
// }

// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (m > 0 && n > 0) { 
//     int ackValue = ackIterative(m, n);
//     Console.WriteLine($"A({m}, {n}) = {ackValue}");
// } else {
//     Console.WriteLine("Числа m и n должны быть неотрицательными");
// }
