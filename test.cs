// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int[] Array = number.ToString().ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();
int sum = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] == 0 || Array[i] > 0) 
    {
      sum++;
    }
}

for (int i = 0; i < Array.Length; i++)
{
    Console.Write(Array[i]);
    if (i < Array.Length - 1)
    {
      Console.Write(", ");
    }
}

Console.Write($" -> {sum}");



/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите числа для нахождения точки пересечения двух прямых");

// double 
// b1 = Convert.ToDouble(Console.ReadLine()),
// b2 = Convert.ToDouble(Console.ReadLine()),
// k1 = Convert.ToDouble(Console.ReadLine()),
// k2 = Convert.ToDouble(Console.ReadLine());

// void FindIntersectionPoint(double b1,double b2,double k1,double k2)
// {
// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;
// double[] points = new double[] {x,y};
// Console.WriteLine($"b1 -> {b1}, b2 -> {b2}, k1 -> {k1}, k2 -> {k2} -> ({points[0]}; {points[1]})");
// }
// FindIntersectionPoint(b1, b2, k1, k2);