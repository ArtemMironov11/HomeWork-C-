// Задайте двумерный массив размером m×n, заполненный случайными вещественными (тип double) числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите размерность матрицы m*n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());


// запмолнить рандомными значениями типа double и вывести на экран
double[,] numbers = new double[m,n];
Random rnd = new Random();
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        // построчное заполнение с применением округления методом Math.Round (double , int)
        numbers[i, j] = Math.Round(rnd.NextDouble()*100, 2); 
        // выведение на экран с применением интерполяции строк F
        // F - (Формат дробных чисел с фиксированной точкой, указывает количество десятичных разрядов после запятой)
        Console.Write("{0,1:F3}", numbers[i, j] + "; ");
    }
    Console.WriteLine();
}