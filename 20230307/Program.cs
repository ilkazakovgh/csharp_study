int[,] CreateRandom2dArray() {
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array) {
    int rowsCount = array.GetLength(0);
    int colsCount = array.GetLength(1);

    for (int i = 0; i < rowsCount; i++) {
        for (int j = 0; j < colsCount; j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Print2dArray(int[,] array) {
    int rowsCount = array.GetLength(0);
    int colsCount = array.GetLength(1);

    for (int i = 0; i < rowsCount; i++) {
        for (int j = 0; j < colsCount; j++)
            if (array[i, j] > 9)
                Console.Write(array[i, j] + " ");
            else    
                Console.Write("0" + array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
//строки двумерного массива.
// void SortRows(int[,] array) {
//     int rowsCount = array.GetLength(0);
//     int colsCount = array.GetLength(1);

//     for (int row = 0; row < rowsCount; row++) {
//         int temp = array[row, 0];
//         for (int i = 0; i < colsCount; i++) {
//             for (int j = i + 1; j < colsCount; j++) {
//                 if (array[row, i] > array[row, j])
//                 {
//                     temp = array[row, i];
//                     array[row, i] = array[row, j];
//                     array[row, j] = temp;
//                 }
//             }
//         }
//     }
// }

// int[,] newArray = CreateRandom2dArray();
// Show2dArray(newArray); 
// SortRows(newArray);
// Show2dArray(newArray); 

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.

// int MinSumRowIndex(int[,] array) {
//     int rowsCount = array.GetLength(0);
//     int colsCount = array.GetLength(1);

//     int minSum = 0;
//     int rowIndex = 0;
//     for (int j = 0; j < colsCount; j++)
//         minSum += array[0, j];

//     for (int i = 1; i < rowsCount; i++) {
//         int rowSum = 0;
//         for (int j = 0; j < colsCount; j++)
//             rowSum += array[i, j];

//         if (rowSum < minSum) {
//             minSum = rowSum;
//             rowIndex = i;
//         }    
//     }

//     return rowIndex;
// }

// int[,] newArray = CreateRandom2dArray();
// Show2dArray(newArray); 
// int minRow = MinSumRowIndex(newArray) + 1;
// Console.WriteLine($"Number of row with min sum of elements is {minRow}");

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// int[,]  matrixProduct(int[,] firstMatrix, int[,] secondMatrix) {
//     int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
//     for (int i = 0; i < firstMatrix.GetLength(0); i++)
//         for (int j = 0; j < secondMatrix.GetLength(1); j++)
//             for (int k = 0; k < secondMatrix.GetLength(0); k++)
//                 result[i,j] += firstMatrix[i,k] * secondMatrix[k,j];

//     return result;
// } 

// int[,] firstMatrix = CreateRandom2dArray();
// int[,] secondMatrix = CreateRandom2dArray();

// Show2dArray(firstMatrix); 
// Show2dArray(secondMatrix); 
// int[,] product = matrixProduct(firstMatrix, secondMatrix);
// Show2dArray(product);


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] Spiral(int size) {
    int[,] result = new int[size, size];
    int rowIndex = 0, colIndex = 0, currentCount = 1;
    while (size > 0) {
        for (int j = colIndex; j <= colIndex + size - 1; j++)
            result[rowIndex, j] = currentCount++;

        for (int i = rowIndex + 1; i <= rowIndex + size - 1; i++)
            result[i, colIndex + size - 1] = currentCount++;

        for (int j = colIndex + size - 2; j >= colIndex; j--)
            result[rowIndex + size - 1, j] = currentCount++;

        for (int i = rowIndex + size - 2; i >= rowIndex + 1; i--)
            result[i, colIndex] = currentCount++;

        rowIndex++;
        colIndex++;
        size -= 2;
    }    
    return result;
}
Console.Write("Введите размер матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] spiral = Spiral(size);
Print2dArray(spiral);

