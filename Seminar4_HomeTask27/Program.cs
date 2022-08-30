//Задача 27: Напишите программу, которая принимает
//на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

int GetNumber()
{
    Console.Write("Введите число: ");
    if (!int.TryParse(Console.ReadLine(), out int number))
    {
        Console.WriteLine("Введите корректное целое число");
    }
    return number;
}

void Sum()
{
    int number = GetNumber();

    int sum = 0;

    int digit = number;

    while (digit != 0)
    {
        sum += digit % 10;
        digit /= 10;
    }

    Console.WriteLine($"Сумма цифр числа: {sum}");

    Sum();
}


Sum();