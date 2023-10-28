// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] Array = number.ToString().ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();
// int sum = 0;
// for (int i = 0; i < Array.Length; i++)
// {
//     if (Array[i] == 0 || Array[i] > 0) 
//     {
//       sum = sum + 1;
//     }
// }
// for (int i = 0; i < Array.Length; i++)
// {
//     Console.Write(Array[i]);
//     if (i < Array.Length - 1)
//             {
//                 Console.Write(", ");
//             }
// }
// Console.Write($" -> {sum}");



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