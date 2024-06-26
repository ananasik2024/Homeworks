// Задача 1**: Напишите программу, которая принимает
// на вход число и проверяет, кратно ли 
// оно одновременно 7 и 23.

// Console.WriteLine("Input number: ");
// int a = Convert.ToInt32 (Console.ReadLine());

// if (a % 7 == 0 && a % 23 == 0)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }


// Задача 2: Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
// выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

// Console.WriteLine("Input X: ");
// int x = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Input Y: ");
// int y = Convert.ToInt32 (Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("Точка находится в первой координатной плоскости");
// }
// if (x <0 && y > 0)
// {
//     Console.WriteLine("Точка находится во второй координатной плоскости");
// }
// if (x < 0 && y < 0)
// {
//     Console.WriteLine("Точка находится в третей координатной плоскости");
// }
// if (x > 0 && y < 0)
// {
//     Console.WriteLine("Точка находится в четвертой координатной плоскости");
// }
// if (x ==0 && y ==0)
// {
//     Console.WriteLine("Точка находится на оси или в начале координат");
// }

// Задача 3: Напишите программу, которая принимает 
// на вход целое число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.

// bool RangeNumber (int num)
// {
//     if(num > 9 && num <100)
//     {
//         return true;
//     }
//     return false;
// }

// void BiggestNumber (int num)
// {
// if (RangeNumber(num))
// {
//     int firstDigit = num / 10;
//     int secondDigit = num % 10;
//     int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
//     System.Console.WriteLine($"The biggest number -> {maxDigit}");
// }
// else
// {
//     System.Console.WriteLine("You input incorrect number");
// }
// }

// System.Console.WriteLine("Input number from [10, 99]: ");
// int a = Convert.ToInt32 (Console.ReadLine());
// BiggestNumber(a);

// Задача 4: Напишите программу, которая на вход 
// принимает натуральное число N, а на выходе 
// показывает его цифры через запятую.

using System;
class Program
{
static void Main()
{
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)
{
Console.WriteLine(N);
}
else
{
while (N > 0)
{
int currentDigit = N % 10;
N /= 10;
if (N > 0)
{
Console.Write(currentDigit + ",");
}
else
{
Console.WriteLine(currentDigit);
}
}
}
}
}



