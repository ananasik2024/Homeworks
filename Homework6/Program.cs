// Задача 1: Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.
// Пример:
// a b c
// d e f => abcdefghi
// g h i

// string MatrixToString(char[,] charMatrix)
// {
//     string result = ""; // Строка для хранения результата из символов матрицы
//     for (int i = 0; i < charMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < charMatrix.GetLength(1); j++)
//         {
//             result += charMatrix[i, j];
//         }
//     }
//     return result;
// }

// char[,] charMatrix =
// {
//     { 'a', 'b', 'c', 'd' },
//     { 'e', 'f', 'g', 'h' }
// };
// Console.WriteLine(MatrixToString(charMatrix));

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.
// Пример:
// AnaStasIya => anastasiya

// string UpperToLowerCase (string str)
// {
//     string result = "";
//     str = str.ToLower();
//     for (int i = 0; i < str.Length; i++)
//     {
//         result += str[i];
//     }
//     return result;
// }

// string str = "WELCOme";
// Console.WriteLine(UpperToLowerCase(str));

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

string ReverseString (string str)
{
    char[] charArray = str.ToCharArray();
	int left = 0;
    int right = charArray.Length - 1;
    while (left < right)
    {
        char temp = charArray[left];
        charArray[left] = charArray[right];
        charArray[right] = temp;

        left++;
        right--;
    }
    return new string(charArray);
}

string str = "А роза упала на лапу Азора";
string cleanedStr = str.Replace(" ", "").ToLower();
string reversedStr = ReverseString(cleanedStr);
if (cleanedStr == reversedStr)
{
	Console.WriteLine ("Строка является палиндромом");
}
else
{
	Console.WriteLine ("Строка НЕ является палиндромом");
}



