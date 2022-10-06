// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2-> 2

// 1, -7, 567, 89, 223-> 3

double[] GetNumbers()
{
  List<double> numbersList = new List<double>();

  while (true)
  {
    string input = Console.ReadLine();

    if (input.ToLower() == "stop") return numbersList.ToArray();

    double num = 0;

    if (!double.TryParse(input, out num))
    {
      Console.Write("Ошибка! >> Некорректное число. Попробуйте ещё: \n");
    }
    else
    {
      numbersList.Add(Convert.ToDouble(input));
    }
  }
}

int CountPositiveNumbers(double[] arr)
{
  int sum = 0;

  foreach (double item in arr)
  {
    if (item > 0) sum++;
  }

  return sum;
}


Console.Write($"Введите числа, после каждого жмите Enter. Чтобы остановиться, введите \"stop\": \n");
double[] arr = GetNumbers();
Console.Write($"\nКоличество введённых чисeл:     {arr.Length}");
Console.Write($"\nКоличество положительных чисeл: {CountPositiveNumbers(arr)}\n");
