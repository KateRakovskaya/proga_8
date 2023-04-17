//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// void InputMatrix(int[,] matrix)
// {
//     Console.WriteLine("Массив: ");
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         for (int j = 0; j < matrix.GetLength(1); j++){
//             matrix[i,j] = new Random().Next(-10, 10);
//             Console.Write($"{matrix[i,j]} \t");
//             }
//             Console.WriteLine();
//             }
// }

// void Sort(int[,] matrix,  int[] size){
//     int t = 0;
//     for (int i = 0; i < size[0]; i++){
//         for (int j = 0; j < size[1]; j++){
//             for (int k = 0; k < size[1]; k++){
//                 if (matrix[i,j] > matrix[i,k]){
//                     t = matrix[i,j];
//                     matrix[i,j] = matrix[i,k];
//                     matrix[i,k] = t;
//                 }
//             }

//         }
//     }
//     Console.WriteLine("Отсортированный массив: ");
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         for (int j = 0; j < matrix.GetLength(1); j++){
//             Console.Write($"{matrix[i,j]} \t");
//             }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите размер массива: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Sort(matrix, size);


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// void InputMatrix(int[,] matrix)
// {
//     Console.WriteLine("Массив: ");
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         for (int j = 0; j < matrix.GetLength(1); j++){
//             matrix[i,j] = new Random().Next(-10, 10);
//             Console.Write($"{matrix[i,j]} \t");
//             }
//             Console.WriteLine();
//             }
// }

// void Sum(int[,] matrix,  int[] size){
//     int[] arr = new int [size[0]];
//     for(int k = 0; k < size[0]; k++){
//         int sum = 0;
//         for(int i = 0; i < size[1]; i++){
//             sum+=matrix[k,i];
//         }
//         arr[k]=sum;
//     }
//     int min = FindMin(arr);
//     Console.Write($"\nНаименьшая сумма элементов в {min+1} строке = {arr[min]}");
// }

// int FindMin(int[] arr){
//     int min = 0;
//     for(int i = 0; i < arr.Length; i++){
//         if (arr[min] > arr [i]) min = i;
//     }
//     return min;
// }

// Console.Write("Введите размер массива: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Sum(matrix, size);


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         for (int j = 0; j < matrix.GetLength(1); j++){
//             matrix[i,j] = new Random().Next(-10, 10);
//             }
//     }
//     Print(matrix);
// }

// void Print(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         for (int j = 0; j < matrix.GetLength(1); j++){
//             Console.Write($"{matrix[i,j]} \t");
//             }
//         Console.WriteLine();
//     }
// }

// void Count(int[,] matrix1, int[,] matrix2)
// { 
//     int[,] res = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     for (int i = 0; i < matrix1.GetLength(0); i++){
//         for (int j = 0; j < matrix2.GetLength(1); j++){
//             res[i, j] = 0;
//             for (int k = 0; k < matrix1.GetLength(0); k++){ 
//                 res[i, j] += matrix1[i, k] * matrix2[k, j];
//                 }
//         }
//     }
//     Console.Write("Результат: \n");
//     Print(res);
// }

// Console.Write("Введите размер первой матрицы: ");
// int[] size1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// Console.Write("Введите размер второй матрицы: ");
// int[] size2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix1 = new int[size1[0], size1[1]];
// int[,] matrix2 = new int[size2[0], size2[1]];
// Console.Write("Матрица 1: \n");
// InputMatrix(matrix1);
// Console.Write("Матрица 2: \n");
// InputMatrix(matrix2);
// if (size1[0]!=size2[1]) Console.Write("Матрицы нельзя умножить");
// else Count(matrix1, matrix2);


//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// void InputMatrix(int[,,] arr)
// {
//     Random rnd = new Random();
//     Console.WriteLine("Массив: ");
//     for (int i = 0; i < arr.GetLength(0); i++){
//         for (int j = 0; j < arr.GetLength(1); j++){
//             for (int k = 0; k < arr.GetLength(2); k++){
//                 int randNumber = rnd.Next(10, 100);
//                 while (Check(arr, randNumber)){
//                     randNumber = rnd.Next(10, 100);
//                 }
//                 arr[i, j, k] = randNumber;
//                 Console.Write($"{arr[i,j,k]} ({i},{j},{k}) \t");
//             }
//         }
//         Console.WriteLine();
//     }
// }

// bool Check(int[,,] arr, int randNumber){
//     for (int i = 0; i < arr.GetLength(0); i++){
//         for (int j = 0; j < arr.GetLength(1); j++){
//             for (int k = 0; k < arr.GetLength(2); k++){
//                 if (arr[i, j, k] == randNumber) return true;
//             }
//         }
//     }
//     return false;
// }

// Console.Write("Введите размер массива: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,,] arr = new int[size[0], size[1], size[2]];
// InputMatrix(arr);


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i,j]} \t");
            }
        Console.WriteLine();
    }
}

void InputMatrix(int[,] matrix, int m, int n)
{
    int t = 1;
    for (int y = 0; y < m; y++) {
        matrix[0,y] = t;
        t++;
    }
    for (int x = 1; x < n; x++) {
        matrix[x, n-1] = t;
        t++;
    }
    for (int y = n - 2; y >= 0; y--) {
        matrix[m-1 , y] = t;
        t++;
    }
    for (int x = m - 2; x > 0; x--) {
        matrix[x , 0] = t;
        t++;
    }
    int c = 1;
    int d = 1;
    while (t < m * n) {
        while (matrix[c,d + 1] == 0) {
            matrix[c,d] = t;
            t++;
            d++;
        }
        while (matrix[c + 1,d] == 0) {
            matrix[c,d] = t;
            t++;
            c++;
        }
        while (matrix[c,d - 1] == 0) {
            matrix[c,d] = t;
            t++;
            d--;
        }
        while (matrix[c - 1,d] == 0) {
            matrix[c,d] = t;
            t++;
            c--;
        }
    }
    for (int x = 0; x < m; x++) {
        for (int y = 0; y < n; y++) {
            if (matrix[x,y] == 0) {
                matrix[x,y] = t;
            }
        }
    }
    Print(matrix);
}

int m = 4;
int n = 4;
int[,] matrix = new int[m, n];
InputMatrix(matrix, m, n);
