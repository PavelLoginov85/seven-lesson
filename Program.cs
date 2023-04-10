// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные
//  числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// System.Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// int finish = n;

// if(n < 0) {
//     int m = Math.Abs(n);
//     System.Console.WriteLine(decrease2(m, 1));
// }
// else {
//     System.Console.WriteLine(decrease(n, 1));
// }



/*-------------------------- Метод --------------------------*/

// Софья, привет. Вопрос, почему метод decrease2 (для отриательных значений) работает как я планирую только 2 раза.
// Пример: -10 -9,8,7,6,5,4,3,2,1. Минус ставит только 2 раза, не понимаю почему? 

// string decrease(int start, int finish){
//     if(start == finish) return finish.ToString();
//     return (start + "," + decrease(start-1, finish));
// }

/*-------------------------- Метод --------------------------*/

// string decrease2(int start, int finish){
//     int start2 = Math.Abs(start);
//     if(start2 == finish) return  finish.ToString();
//     return ("-"+ start2 + " -" + decrease(start2-1, finish));
// }



// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// System.Console.Write("Введите первое число: ");
// int m = int.Parse(Console.ReadLine()!);


// System.Console.Write("Введите второе число: ");
// int n = int.Parse(Console.ReadLine()!);

// System.Console.WriteLine(Plus(m,n));

// //System.Console.WriteLine($"Сумма цифр от {m} до {n} равна {Plus(m,n)}");
// System.Console.WriteLine(Plus(m,n));

// /*--------------------------- Method ---------------------------*/

// int Plus (int firstNum, int lastNum){
//     int sum = 0;
//     if(firstNum > lastNum) return sum;
//     return sum += firstNum + Plus(firstNum + 1, lastNum);
// }



// Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Console.WriteLine("Введите первое число :");
// int m = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите второе число :");
// int n = int.Parse(Console.ReadLine()!);

// /*-------------------------------- Метод Аккермана ---------------------*/
// int AckermannFunction (int first, int second)
// {
//     if (first == 0) return second + 1;
//     if (first != 0 && second == 0) return AckermannFunction(first - 1, 1);
//     if (first > 0 && second > 0) return AckermannFunction(first - 1, AckermannFunction(first, second - 1));
// return AckermannFunction(first, second);
// }

// Console.WriteLine($" Аккерман для чисел:({m},{n}) равен {AckermannFunction(m, n)}");






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

 


