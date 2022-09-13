// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3->A(m, n) = 29

// !! В примере задачи ошибка: m и n перепутаны местами. A(2, 3) = 9; A (3, 2) =  29;
// https://ru.wikipedia.org/wiki/Функция_Аккермана#Таблица_значений

int Ankerman(int m, int n)
{

  if (m == 0) return n + 1;

  if (m > 0 && n == 0) return Ankerman(m - 1, 1);

  if (m > 0 && n > 0) return Ankerman(m - 1, Ankerman(m, n - 1));

  return 0;
}

int GetNumber(string what)
{
  int number;
  System.Console.Write($"Введите число {what}: ");
  while (!int.TryParse(Console.ReadLine(), out number))
  {
    System.Console.Write("Введите корректное целое число. Попробуйте ещё: ");
  }
  return number;
}

int m = GetNumber("m");
int n = GetNumber("n");

// !! В примере задачи ошибка: m и n перепутаны местами. A(2, 3) = 9; A (3, 2) =  29;
// https://ru.wikipedia.org/wiki/Функция_Аккермана#Таблица_значений
Console.WriteLine($"A({m}, {n}) = {Ankerman(m, n)}");
