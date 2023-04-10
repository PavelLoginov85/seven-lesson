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






