// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь 
// содержит информацию о том, сколько раз встречается элемент входных данных.


Console.Write("Введите размер массива: ");
string [] SizeArray = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] SizeArrayInt  = SizeArray.Select(int.Parse).ToArray();

if(SizeArrayInt[0]>5 || SizeArrayInt[1] > 5){

    System.Console.WriteLine("Размер массива не более 5 ");
}

else{
int [,] trueArray = initArray(SizeArrayInt);
System.Console.WriteLine();
System.Console.WriteLine("Получился массив");
System.Console.WriteLine();
StroyArray(trueArray);
System.Console.WriteLine();
System.Console.WriteLine("Итого:");
System.Console.WriteLine();
Slovar(trueArray);
System.Console.WriteLine();
    
}

// /*--------------------------------------- Метод иницилизации --------------------------*/

int [,] initArray (int [] array)
{
    int[,] arrayForSum = new int[array[0], array[1]];
    for (int i = 0; i < array[0]; i++)
    {
        for (int j = 0; j < array[1]; j++)
        {
           
            arrayForSum[i, j] = new Random().Next(1, 7);
        }

    }
    return arrayForSum;
}
/*--------------------------------------- Метод заполнени массива --------------------------*/
void StroyArray(int[,] array)
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

/*--------------------------------------- Метод заполнени массива --------------------------*/
 void Slovar (int[,] slovArray )
{
      int count1 = 0; int count2 = 0; int count3 = 0; int count4 = 0; int count5 = 0; int count6 = 0;

     for (int i = 0; i < slovArray.GetLength(0); i++)
    {
        for (int j = 0; j < slovArray.GetLength(1); j++)
        {   
           
           if(slovArray[i,j] == 1) count1 += 1;
           if(slovArray[i,j] == 2) count2 += 1;
           if(slovArray[i,j] == 3) count3 += 1;
           if(slovArray[i,j] == 4) count4 += 1;
           if(slovArray[i,j] == 5) count5 += 1;
           if(slovArray[i,j] == 6) count6 += 1;
         }
             
           
     }
    Console.WriteLine($"1 встретился {count1} раз"); 
    Console.WriteLine($"2 встретился {count2} раз"); 
    Console.WriteLine($"3 встретился {count3} раз"); 
    Console.WriteLine($"4 встретился {count4} раз");
    Console.WriteLine($"5 встретился {count5} раз"); 
    Console.WriteLine($"6 встретился {count6} раз");
 }



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.Write("Введите через пробел размер матрицы А: ");
// string [] MatrixA = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[] MatrixA_Int  = MatrixA.Select(int.Parse).ToArray();

// Console.Write("Введите через пробел размер матрицы В: ");
// string [] MatrixB = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[] MatrixB_Int  = MatrixB.Select(int.Parse).ToArray();

// if(MatrixA_Int[1] != MatrixB_Int[0]){
//     System.Console.WriteLine("Кол-во столбцов матрицы А, строго должно равняться кол-ву строк матрицы В");
//     System.Console.WriteLine("Введите правильно данные. Пример: А [3 , 2]; В [2,3].");
// }
// else{
// System.Console.WriteLine("Матрица А");
// int[,] FirstMatrix = initMatrix(MatrixA_Int);
// FillMatrix(FirstMatrix);

// System.Console.WriteLine();

// System.Console.WriteLine("Матрица В");
// int[,] SecondMatrix = initMatrix(MatrixB_Int);
// FillMatrix(SecondMatrix);

// System.Console.WriteLine("Получаем произведение");
// FillMatrix(Increase(FirstMatrix ,SecondMatrix ));

// }

// /*------------------------------------- init matrix -------------------------*/

// int [,] initMatrix (int [] array)
// {
//     int[,] arrayForSum = new int[array[0], array[1]];
//     for (int i = 0; i < array[0]; i++)
//     {
//         for (int j = 0; j < array[1]; j++)
//         {
           
//             arrayForSum[i, j] = new Random().Next(1, 7);
//         }

//     }
//     return arrayForSum;
// }


// /*------------------------------------- Fill matrix -------------------------*/

// void FillMatrix(int[,] array)
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

// /*-------------------------------------  matrix -------------------------*/

// int [,] Increase(int[,] array , int [,] massive)
// {
// int[,] total = new int[array.GetLength(0), array.GetLength(1)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < massive.GetLength(1); j++)
//         {
//            total[i, j] = 0;
//            for(int k = 0; k < array.GetLength(1); k++){
//             total[i,j] += array[i,k] * massive[k,j];

//            }
            
//         }

//     }
//     return total;
// }

 






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

// System.Console.Write("Введите число строк: ");
// int quantityRows = int.Parse(Console.ReadLine()!);

// System.Console.Write("Введите число столбцов: ");
// int quantityColumns = int.Parse(Console.ReadLine()!);

// int[,] massiveForSum = buildArray(quantityRows, quantityColumns);
// System.Console.WriteLine();
// FillingArray(massiveForSum);
// System.Console.WriteLine();
// Console.WriteLine($"среднее значение по столбцам:{String.Join("; ", AverageNumber(massiveForSum))}");


/*---------------------------Build Array --------------------*/

// int[,] buildArray(int r, int c)
// {
//     int[,] arrayForSum = new int[r, c];
//     for (int i = 0; i < r; i++)
//     {
//         for (int j = 0; j < c; j++)
//         {
//             //arrayForSum[i, j] = (i * c) + j + 1;
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

// // /*--------------------------- Method Average number --------------------*/

//  double [] AverageNumber(int[,] AverageArray)
// {
//     double [] t = new double [AverageArray.GetLength(1)];
     
//      for (int i = 0; i < AverageArray.GetLength(1); i++)
//     {
//          double sum = 0;
//         for (int j = 0; j < AverageArray.GetLength(0); j++)
//         {
//             sum += AverageArray[j,i];
//          }
//             t[i]=Math.Round(sum/AverageArray.GetLength(0),2);
//      }
//     return t;
//  }


