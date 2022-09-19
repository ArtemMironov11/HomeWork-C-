// Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Номер строки с наименьшей суммой элементов: 1 строка
// (допускается указывать индекс строки в массиве, в данном примере - 0)


Console.WriteLine("Введите размерность матрицы m*n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());


// запмолнить рандомными целочисленными значениями
int [,] matrix = new int [m,n];
Random rnd = new Random();
// вводим массив для суммирования
int[] array = new int [m];


for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        // вводим ограничение в цифрах от 0 до 9
        matrix[i, j] = rnd.Next(1, 10);
        sum += matrix[i,j];
        // выводим массив
        Console.Write($"{matrix[i, j]}\t");
    }
    array[i] = sum;
    // Вывод суммы элементов строки
    Console.Write($"\t\t{array[i]} ");    
    sum = 0;
    Console.WriteLine("");
}

int count = 0;
int min_string_in_matrix = array [0];

for(int i = 1; i < m; i++)               // Нахождение минимальной суммы
{
    if(array[i] < min_string_in_matrix)
    {
        min_string_in_matrix = array[i];
        count = i;
    }
}

Console.WriteLine($"\n\tНомер строки с наименьшей суммой элементов: {count + 1} строка");