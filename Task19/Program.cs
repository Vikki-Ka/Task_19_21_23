/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Clear();
int getUserValue(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

void checkPalindrom(int number)
{
    if (number >= 10000 && number < 100000)
    {
        int d1 = number / 10000;
        int d2 = number / 1000 % 10;
        int d3 = number / 100 % 10;
        int d4 = number / 10 % 10;
        int d5 = number % 10;       
    
        if (d1 == d5 && d2 == d4)
        {
            Console.Write($"Число {number} - палиндром");
        }
        else 
        {
            Console.Write($"Число {number} - непалиндром!");
        }
    }    
    else
    {
        Console.WriteLine("Ввидите пятизначное число!:))");
    }
}

int number = getUserValue("Ввидите пятизначное число ");
checkPalindrom(number);