/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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

int Akkerman(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else if (numberN == 0 && numberM > 0)
    {
        return Akkerman(numberM - 1, 1);
    }
    else
    {
        return (Akkerman(numberM - 1, Akkerman(numberM, numberN - 1)));
    }
}

int numberM = GetNumber("Введите число");
int numberN = GetNumber("Введите число");

Console.WriteLine(Akkerman(numberM,numberN));
