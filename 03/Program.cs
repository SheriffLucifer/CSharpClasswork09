// Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.


Console.Clear();
int number = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int sumNumbers = RecurrSum(number);
Console.WriteLine($"{number} -> {sumNumbers}");

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

int RecurrSum(int n3)
{
    if (n3 == 0) return 0;
    else
    {
        return n3 % 10 + RecurrSum(n3 / 10);
    }
}