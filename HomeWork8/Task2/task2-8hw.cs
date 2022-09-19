// Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите размерность матрицы m*n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());


// запмолнить рандомными целочисленными значениями 2 матрицы одинакового размера
int [,] matrix1 = new int [m,n];
int [,] matrix2 = new int [m,n];
Random rnd = new Random();
void RandomArr(int[,] arrname)
{
    for (int i = 0; i < arrname.GetLength(0); i++)
    {
        for (int j = 0; j < arrname.GetLength(1); j++)
        {
            // вводим ограничение в цифрах от 0 до 9
            arrname[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintArr(int[,] arrname)
{
    // Заполнить матрицу рандомными числами
    // Console.WriteLine("Массив со случайными числами:");
    for (int i = 0; i < arrname.GetLength(0); i++)
    {
        for (int j = 0; j < arrname.GetLength(1); j++)
        {
            // выводим массив на экран
            Console.Write($"{arrname[i, j]}\t");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}
Console.WriteLine("\nМатрица A:");
RandomArr(matrix1);
PrintArr(matrix1);
Console.WriteLine("\nМатрица B:");
RandomArr(matrix2);
PrintArr(matrix2);
Console.WriteLine("\nМатрица C = A * B:");
int[,] C = Multiplication(matrix1, matrix2);
Print(C);

int[,] Multiplication(int[,] a, int[,] b)
{
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}

void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0} ", $" {a[i, j]}\t");
        }
        Console.WriteLine();
    }
}