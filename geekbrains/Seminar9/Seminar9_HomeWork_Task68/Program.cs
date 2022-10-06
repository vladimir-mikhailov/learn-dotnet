// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3->A(m, n) = 29

// !! В примере задачи ошибка: m и n перепутаны местами. A(2, 3) = 9; A (3, 2) =  29;
// https://ru.wikipedia.org/wiki/Функция_Аккермана#Таблица_значений

int Akkerman(int m, int n)
{
  if (m < 0 || n < 0)
  {
    System.Console.WriteLine("Ошибка: функция Аккермана принимает только целые неотрицательные числа.");
    return -1;
  }

  if (m == 0) return n + 1;

  if (n == 0) return Akkerman(m - 1, 1);

  return Akkerman(m - 1, Akkerman(m, n - 1));
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

Console.WriteLine("");
int m = GetNumber("m");
int n = GetNumber("n");

// !! В примере задачи ошибка: m и n перепутаны местами. A(2, 3) = 9; A (3, 2) =  29;
// https://ru.wikipedia.org/wiki/Функция_Аккермана#Таблица_значений
Console.WriteLine("");
Console.WriteLine($"A({m}, {n}) = {((Akkerman(m, n) > 0) ? Akkerman(m, n) : "так эта штука не работает")}");
Console.WriteLine("");
