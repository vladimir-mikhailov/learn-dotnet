//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

int GetNumber()
{
  System.Console.Write("Введите число, не обязательно пятизначное: ");
  if (!int.TryParse(Console.ReadLine(), out int number))
  {
    System.Console.WriteLine("Введите корректное целое число.");
  }
  return number;
}

bool isPalyndrome(int number)
{

  int reverse = 0;

  int temp = number;

  while (temp != 0)
  {
    reverse = (reverse * 10) + (temp % 10);

    temp /= 10;
  }

  return (reverse == number);
}

Console.WriteLine(isPalyndrome(GetNumber()) ? "Палиндром" : "Не палиндром");
