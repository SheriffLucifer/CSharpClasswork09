// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.

Console.Clear();
int x = GetNumberFromUser("Введите целое число M: ", "Ошибка ввода!");
int y = GetNumberFromUser("Введите целое число N: ", "Ошибка ввода!");
int sumNumbers = MultReccur(x, y);
Console.WriteLine($"M = {x}; N = {y} -> {sumNumbers}");


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

int MultReccur(int x, int y)
{
    if (y == 1) return x;
    else
    {
        return x * MultReccur(x, y - 1);
    }
}