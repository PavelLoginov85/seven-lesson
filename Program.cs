// // Задача 47. Задайте двумерный массив размером m×n, 
// // заполненный случайными вещественными числами.

// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9

// Console.Write("Введите количество строк: ");
// int m = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int n = int.Parse(Console.ReadLine()!);
// double [,] realArray = buildArray ( m , n);
// System.Console.WriteLine();
// PrintArray(realArray);
// System.Console.WriteLine();
// // /*-------------------------- Method Filling --------------------------------- */

// double [,] buildArray(int row, int column){

//     double [,] realNumbers = new double  [row, column];
//     Random size = new Random();
//     for (int i = 0; i < row; i++)
//     {
//         for(int j = 0; j < column; j++){
//             realNumbers[i, j] = Math.Round((size.NextDouble()) * 100, 2); 
//         }
//     }
//     return realNumbers;
// }

// //  /*-------------------------- Method Print ------------------------  */

// void PrintArray(double [,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }





//  Задача 50. Напишите программу, которая на вход принимает два числа(строка, столбец), 
//  проверяя есть ли такая позиция в двумерном массиве и возвращает сообщение о том, что оно найдено, 
//  а также какое число стоит на этом месте или же указание, что такого элемента нет.
//  Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 1, j = 3 -> Такой элемент есть: 3
// i = 4, j = 2 -> такого элемента в массиве нет


// System.Console.Write("Введите номер строк: ");
// int Rows = int.Parse(Console.ReadLine()!);

// System.Console.Write("Введите номер столбца: ");
// int Columns = int.Parse(Console.ReadLine()!);

// int[,] massiveForSum = buildArray(5, 5);
// System.Console.WriteLine();
// FillingArray(massiveForSum);
// System.Console.WriteLine();


// if(Rows < 5 && Columns < 5 && Rows >= 0 && Columns >= 0){
// Console.WriteLine($"Такой элемент есть:{massiveForSum [Rows,Columns]}");
// }
// else {
//     System.Console.WriteLine("Такого элемента нет в массиве.");
// }
// System.Console.WriteLine();
// /*---------------------------Build Array --------------------*/

// int[,] buildArray(int r, int c)
// {
//     int[,] arrayForSum = new int[r, c];
//     for (int i = 0; i < r; i++)
//     {
//         for (int j = 0; j < c; j++)
//         {
//             arrayForSum[i, j] = new Random().Next(1, 10);
//         }

//     }
//     return arrayForSum;
// }

// /*-------------------------------- Fill Array ------------------------*/

// void FillingArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

System.Console.Write("Введите число строк: ");
int quantityRows = int.Parse(Console.ReadLine()!);

System.Console.Write("Введите число столбцов: ");
int quantityColumns = int.Parse(Console.ReadLine()!);

int[,] massiveForSum = buildArray(quantityRows, quantityColumns);
System.Console.WriteLine();
FillingArray(massiveForSum);
System.Console.WriteLine();
Console.WriteLine($"среднее значение по столбцам:{String.Join("; ", AverageNumber(massiveForSum))}");


/*---------------------------Build Array --------------------*/

int[,] buildArray(int r, int c)
{
    int[,] arrayForSum = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            //arrayForSum[i, j] = (i * c) + j + 1;
            arrayForSum[i, j] = new Random().Next(1, 10);
        }

    }
    return arrayForSum;
}

/*-------------------------------- Fill Array ------------------------*/

void FillingArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// // /*--------------------------- Method Average number --------------------*/

 double [] AverageNumber(int[,] AverageArray)
{
    double [] t = new double [AverageArray.GetLength(1)];
     
     for (int i = 0; i < AverageArray.GetLength(1); i++)
    {
         double sum = 0;
        for (int j = 0; j < AverageArray.GetLength(0); j++)
        {
            sum += AverageArray[j,i];
         }
            t[i]=Math.Round(sum/AverageArray.GetLength(0),2);
     }
    return t;
 }


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

