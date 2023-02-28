﻿/**
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNumber(string massange)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(massange);

        if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не коррректное число. Пвторите ввод");
        }
    }

    return result;
}

string GetNaturalNumber(int number)
{
    if (number == 1)
    return "1";
    return number.ToString() + " " + GetNaturalNumber(number - 1);          
}

int number = GetNumber("Введите число");

Console.WriteLine(GetNaturalNumber(number));