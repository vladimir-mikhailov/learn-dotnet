// Задача 42: Перевести десятичное число в двоичное

string ConvertIntToBinary(int num)
{
    int modulus = 0;
    string dec = string.Empty;

    do
    {
        modulus = num % 2;
        dec += modulus;
        num = num / 2;

    } while (num > 0);


    char[] arr = new char[dec.Length];
    arr = dec.ToCharArray();
    dec = String.Join("", arr.Reverse());

    return dec;
}


// Через рекурсию

void printBinary(int num)
{
    if (num <= 0) return;
    else
    {
        printBinary(num / 2);
        Console.Write(num % 2);
    }
}


Console.WriteLine($"Через цикл и строку: {ConvertIntToBinary(44)}");

Console.Write($"Через рекурсию: ");
printBinary(44);