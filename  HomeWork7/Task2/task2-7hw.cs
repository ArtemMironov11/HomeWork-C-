// Напишите программу, которая на вход принимает позиции (две) элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.



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
Console.WriteLine("Введите позиции искомого элемента, строку и столбец: ");
int i_row = Convert.ToInt32(Console.ReadLine());
int j_column = Convert.ToInt32(Console.ReadLine());

if(i_row < matrix.GetLength(0) && j_column < matrix.GetLength(0))
{
    Console.Write($"Мы его нашли! Он равен: {matrix[i_row, j_column]}");
}
else
{
    Console.Write($"Таких не имеем");
}