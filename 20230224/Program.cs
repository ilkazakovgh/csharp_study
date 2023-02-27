//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите 
//программу, которая покажет количество чётных чисел в массиве.

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

// double[] InputArrayDouble(int size) {
//     double[] result = new Double[size];

//     for(int i = 0; i < size; i++) {
//         Console.Write($"Введите {i + 1}-й элемент: ");
//         result[i] = Convert.ToDouble(Console.ReadLine());
//     }

//     return result;
// }

// double Min(double[] array) {
//     if (array.Length == 0)
//         return 0;

//     double result = array[0];

//     for(int i = 1; i < array.Length; i++)
//         if (array[i] < result)
//             result = array[i];

//     return result;
// }

// double Max(double[] array) {
//     if (array.Length == 0)
//         return 0;

//     double result = array[0];
    
//     for(int i = 1; i < array.Length; i++)
//         if (array[i] > result)
//             result = array[i];

//     return result;
// }

// void ShowArrayDouble(double[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int EventElementsCount(int[] array) {
//     int result = 0;
//     for(int i = 0; i < array.Length; i++)
//         if (array[i] % 2 == 0)
//             result++;

//     return result;
// }

// Console.Write("Введите количество элементов в массиве: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(size, 100, 999);
// ShowArray(array);
// Console.WriteLine("Количество четных элементов: " + EventElementsCount(array));

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int OddPositionElementsSum(int[] array) {
//     int result = 0;
//     for(int i = 1; i < array.Length; i += 2)
//         result += array[i];

//     return result;
// }

// Console.Write("Введите количество элементов в массиве: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(size, 1, 10);
// ShowArray(array);
// Console.WriteLine("Сумма элементов на нечетных позициях: " + OddPositionElementsSum(array));

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Console.Write("Введите количество элементов в массиве: ");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] array = InputArrayDouble(size);
// ShowArrayDouble(array);

// double min = Min(array);
// double max = Max(array);
// double minMaxDiff = max - min;

// Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементами: {minMaxDiff}");
