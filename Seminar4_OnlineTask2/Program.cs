//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//4 -> 24
//5 -> 120

int GetNumber()
{
  Console.Write("Введите число: ");
  if (!int.TryParse(Console.ReadLine(), out int number))
  {
    Console.WriteLine("Введите корректное целое число");
  }
  return number;
}

int Factorial(int number)
{
  int fact = 1;

  for (int i = 2; i <= number; i++)
  {
    fact *= i;
  }

  return fact;
}

Console.WriteLine($"Факториал числа: {Factorial(GetNumber())}");
