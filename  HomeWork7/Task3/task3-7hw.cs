// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите размерность матрицы m*n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());


// запмолнить рандомными целочисленными значениями
int [,] matrix = new int [m,n];
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        // вводим ограничение в цифрах от 0 до 9
        matrix[i, j] = rnd.Next(1, 10);
        // выводим массив
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine("");
}

double[] avg = new double[matrix.GetLength(1)];
for(int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    avg[j] = sum / matrix.GetLength(0);
}

Console.WriteLine("Среднее арифметическое каждого столбца:");

for(int i = 0; i < matrix.GetLength(1); i++)
{
    Console.WriteLine("{0:F2}", avg[i]);
}
