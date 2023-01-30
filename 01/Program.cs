// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N.


Console.Clear();
int num = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
string sumNumbers = ShowIntegers(1, num);
Console.WriteLine($"{num} -> {sumNumbers}");


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
    else return start + " " + ShowIntegers(start + 1, end);
}