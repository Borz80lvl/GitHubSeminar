// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// using System;
// class Program {
//     static void Main () 
// {
//     Console.WriteLine("Введите число N:");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.Write($"N = {n} -> ");
//     FromNtoOne(n);
// }

// static void FromNtoOne(int n)
// {
//     if (n > 1)
//     {
//         Console.Write($"{n}, ");
//         FromNtoOne(n - 1);
//     }
//     else 
//     {
//         Console.Write(1);
//     }
// }
// }



////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// using System;
// class Program {
//     static void Main () 
// {
//     Console.WriteLine("Введите число M и N:");
//     int M = Convert.ToInt32(Console.ReadLine());
//     int N = Convert.ToInt32(Console.ReadLine());    
//     Console.Write($"M = {M};N = {N} -> ");
//     Console.WriteLine(Akkerman(M, N));
// }

// static int Akkerman(int M, int N)
// {
//     if (M > N)
//     {
//         return 0;
//     }
//     else 
//     {
//         return M + Akkerman(M + 1,N);
//     }
// }
// }



////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
using System;
class Program {
    static void Main () 
{
    Console.WriteLine("Введите число M и N:");
    int M = Convert.ToInt32(Console.ReadLine());
    int N = Convert.ToInt32(Console.ReadLine());    
    Console.Write($"M = {M};N = {N} -> ");
    Console.WriteLine(Akkerman(M, N));
}

static int Akkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    if (M > 0 && N == 0) 
    {
        return Akkerman(M - 1,1);
    } 
    if (M > 0 && N > 0)
    {
        return Akkerman(M - 1,Akkerman(M,N - 1));
    }
    else 
    {
        return 0;
    }
}
}