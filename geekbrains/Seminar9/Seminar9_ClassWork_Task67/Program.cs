// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453-> 12
// 45-> 9


int GetSum(int num)
{
  if (num < 10) return num % 10;
  return num % 10 + GetSum(num / 10);
}

Console.WriteLine(GetSum(555));
