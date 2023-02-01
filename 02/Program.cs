// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.


Console.Clear();
int m = GetNumberFromUser("Введите целое число M: ", "Ошибка ввода!");
int n = GetNumberFromUser("Введите целое число N: ", "Ошибка ввода!");

Console.Write($"M = {m}; N = {n} -> ");
if (m < n) Console.WriteLine(ShowIntegers(m, n));
else Console.Write(ShowIntegers(n, m));

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

string ShowIntegers(int start, int end)
{
    if (start == end)
    {
        return end.ToString();
    }
    else
    {
        return start + " " + ShowIntegers(start + 1, end);
    }
}