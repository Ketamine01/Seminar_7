//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите строчку, значение которого хотите получить: ");
 int strok = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите столиб, значение которого хотите получить: ");
 int stolb = Convert.ToInt32(Console.ReadLine());
 int m = 4;
 int n = 5;

 int[,] array = new int[m, n];
 void FillArray(int[,] matr)
 {
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
        
    }
 }
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");

        }
        Console.WriteLine();
    }
}

 FillArray(array);
 PrintArray(array);
 Console.WriteLine();

    if (strok < 0 | strok > array.GetLength(0) - 1 | stolb < 0 | stolb > array.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент не существует");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", array[strok, stolb]);
    }
