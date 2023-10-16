//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
int week_days = 7;
Console.WriteLine("Введите число дня недели");
int week = Convert.ToInt32(Console.ReadLine());
if (week < 1 || week > week_days) {
    Console.WriteLine("Введенное число не является числом дня недели");
}
if (week == 6 || week == 7) {
    Console.WriteLine($"{week} -> да");
}
else
{
    Console.WriteLine($"{week} -> нет");
}