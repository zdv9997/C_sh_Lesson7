// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

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

double sum = 0.0;
double count = 0.0;
double sredneeArifmet = 0;

for (int i = 0; i < array.GetLength(1); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum = sum + array[j, i];
        count++;
    }
    sredneeArifmet = Math.Round((sum / count), 2);
    Console.WriteLine($"Среднее арифметическое столбца {i + 1} = {sredneeArifmet}");
    sum = 0.0;
    count = 0.0;
}

PrintArray(array);
