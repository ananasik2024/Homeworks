// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. Использовать рекурсию, 
// не использовать циклы.

// void printNaturalNumbers(int M, int N) 
// {
//     if (M < N)
//     {
//         Console.Write(M + " ");
//         printNaturalNumbers(M + 1, N);
//     }
//     else if (M > N)
//     {
//         Console.Write(M + " ");
//         printNaturalNumbers(M - 1, N);
//     }
//     else
//     {
//         Console.Write(M + " ");
//     }   
// }

// printNaturalNumbers(2, 8);

// Задача 2: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.

// int Ackermann(int m, int n) 
// {
//     if (m == 0)
//     {
//         return n + 1;//если m == 0 сразу в условии, то после этого функция сразу завершается прибавляя 1 к n
//     }
//     else if (m > 0 && n == 0)
//     {
//         return Ackermann(m - 1, 1);
//     }
//     else //(m > 0 && n > 0)
//     {
//         return Ackermann(m - 1, Ackermann(m, n - 1));
//     }
// }

// int m = 0;
// int n = 1;
// int result = Ackermann(m, n);
// Console.WriteLine ($"A({m}, {n}) = {result}");

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void printArrayReverse(int[] array, int size) 
{
    if (size >= 0)
    {
        Console.Write(array[size] + " ");
        printArrayReverse(array, size - 1);
    }
}

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
printArrayReverse(array, array.Length - 1);



