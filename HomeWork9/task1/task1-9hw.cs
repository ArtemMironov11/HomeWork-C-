// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки
//  двумерного массива.
Console.WriteLine("Введите размерность матрицы m*n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
Random rnd = new Random();
void RandomArray(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = rnd.Next(10, 99);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < m; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.Write("] ");
        Console.Write($"\n");
    }
}

RandomArray(array);
void FillArray(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m-1; j++)
        {
            for (int k = 0; k < m-1; k++)
            {
                if (array[i, k] < array[i, k+1])
                {
                    int tmp;
                    tmp = array[i, k];
                    array[i, k] = array[i, k+1];
                    array[i, k+1] = tmp;

                }
            }
        }
    }
}
RandomArray(array);
PrintArray(array);
Console.WriteLine("______________");
FillArray(array);
PrintArray(array);