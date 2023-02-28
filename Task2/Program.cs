/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

int GetSum(int numberM, int numberN)
{
    int res = numberM;
    if (numberM == numberN)
        return 0;
    else
    {
        numberM++;
        res = numberM + GetSum(numberM, numberN);
        return res;
    }
}

int numberM = GetNumber("Введите число");
int numberN = GetNumber("Введите число");

Console.WriteLine(GetSum(numberM -1, numberN));
