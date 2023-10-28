Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Console.WriteLine("Напишите число,которое будет возводиться в степень: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите степень: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write($"{A},{B} -> {Math.Pow(A, B)}");


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] Array = number.ToString().ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();
// int sum = 0;
// for (int i = 0; i < Array.Length; i++)
// {
//     sum = sum + Array[i];
// }
// Console.WriteLine($"{number} -> {sum}");

 
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Random random = new Random();
// int[] numbers = new int[8];
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = random.Next(1, 101);
// }
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.Write(numbers[i]);
//     Console.Write("  ");
// }