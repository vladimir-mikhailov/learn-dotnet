//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4-> 16

int GetNumber(char numberName)
{
    Console.Write($"Введите число {numberName}: ");
    if (!int.TryParse(Console.ReadLine(), out int number)) //TODO число может быть не только целое
    {
        Console.WriteLine("Введите корректное число");
    }
    return number;
}

int GetPower(int num, int pow)
{
    int res = 1;

    for (int i = 1; i <= pow; i++)
    {
        res *= num;
    }
    return res;
}

void Empower()
{
    int a = GetNumber('A');
    int b = Math.Abs(GetNumber('B'));

    Console.WriteLine($"{a} в степени {b} равно {GetPower(num: a, pow: b)}");

    Empower();
}


Empower();