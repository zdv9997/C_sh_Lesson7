// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 17 -> такого числа в массиве нет

Console.Clear();
int[,] array = new int[,]
{
{1, 4, 7, 2},{ 5,9,2,3},{ 8,4,2,4}
};


void PrintArray(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите позиции элемента: строка и столбец");
int str = Convert.ToInt32(Console.ReadLine());
int col = Convert.ToInt32(Console.ReadLine());
if (str < array.GetLength(0) & col < array.GetLength(1)) Console.WriteLine($"Число = {array[str, col]}");
else Console.WriteLine("Числа с такой позицией нет в массиве");

Console.Write("Введите число для проверkи: ");
int num = Convert.ToInt32(Console.ReadLine());
bool availab = false;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == num)
        {
            Console.WriteLine($"Позиция числа {num} в массиве: строка {i + 1} столбец {j + 1}");
            availab = true;
        }
    }
}
if (availab == false) Console.WriteLine($"Числа {num} нет в массиве");
PrintArray(array);