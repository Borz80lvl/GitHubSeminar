// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехначное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number} -> {number / 10 % 10}");






//Задача 2
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Console.WriteLine("Введите трехначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 100) {
// Console.WriteLine($"{number} -> третьей цифры нет");
// }
// else {
// Console.WriteLine($"{number} -> {Math.Round(Convert.ToDouble(number / 10 % 10))}");
// }

//Задача 3
//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// int week_days = 7;
// Console.WriteLine("Введите число дня недели");
// int week = Convert.ToInt32(Console.ReadLine());
// if (week < 1 || week > week_days) {
//     Console.WriteLine("Введенное число не является числом дня недели");
// }
// if (week == 6 || week == 7) {
//     Console.WriteLine($"{week} -> да");
// }
// else
// {
//     Console.WriteLine($"{week} -> нет");
// }