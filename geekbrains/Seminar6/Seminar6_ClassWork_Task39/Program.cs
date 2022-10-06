// Задача 39: Развернуть одномерный массив.

int[] GenerateArray(int size)
{
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i <= arr.Length - 1; i++)
    {
        arr[i] = rnd.Next(0, 101);
    }
    return arr;
}

var arr = GenerateArray(10);

Console.WriteLine
    (
        $"{"Исходный массив: ".PadRight(30)}" +
        $"{String.Join(", ", arr).PadLeft(50)}"
    );
Console.WriteLine
    (
        $"{"Перевёрнутый массив: ".PadRight(30)}" +
        $"{String.Join(", ", arr.Reverse()).PadLeft(50)}"
    );