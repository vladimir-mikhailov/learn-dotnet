// Задача 69. Функция принимает на вход А и В и возводит число А в целую степень В с помощью рекурсии.

int GetPow(int num, int pow)
{
  if (pow == 1) return num;
  return num * GetPow(num, pow - 1);
}

Console.WriteLine(GetPow(3, 5));
