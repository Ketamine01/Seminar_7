//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.m = 3, n = 4 

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = (new Random()).Next(-999, 1000) / 100.0;
        }
    }
}
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write($"[");
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            Console.Write($"{matr[i, j]}|");
        }
        Console.WriteLine($"{matr[i, matr.GetLength(1) - 1]}");
    }
}
Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите длинну строки: ");
int n = int.Parse(Console.ReadLine()!);
double[,] array = new double[m, n];
Console.Clear();
FillArray(array);
PrintArray(array);