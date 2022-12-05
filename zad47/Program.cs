// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
Console.Clear();
Console.Write("Enter the number of lines: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
Random x = new Random();
void FillArray(double[,] masive)
{
    for (int i = 0; i < masive.GetLength(0); i++)
    {
        Console.WriteLine($"Enter elements of line {i}: ");
        for (int j = 0; j < masive.GetLength(1); j++)
        {
            masive[i, j] = Math.Round(x.NextDouble() / 10, 2);
        }
        Console.WriteLine();
    }
}
void PrintArray(double[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j],2} ");
        }
        Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);

