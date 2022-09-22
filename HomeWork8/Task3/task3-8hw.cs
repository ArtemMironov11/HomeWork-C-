// Задача 3. Сформируйте двухмерный массив из неповторяющихся двузначных чисел 
// (размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив.
// Вариант создания функции:
// Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
// Пример:
// Массив размером 3 x 3
// 10 11 55
// 33 41 23
// 17 28 34

Console.WriteLine("Введите размерность матрицы m*n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

if (m * n > 50)
{
    Console.WriteLine("Кол-во элементов матрицы выше допустимого (50)");
    return;
}


int[,] matrix = new int[m, n];
Random rnd = new Random();
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.Write($"\n");
    }
}
void FillArray(int[,] matrix)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            int num;
            do
            {
                num = rnd.Next(10, 100);
            }
            while (Contains(matrix, num) == true);
            matrix[i, j] = num;
        }
    }
}

bool Contains(int[,] matrix, int rate)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (matrix[i, j] == rate)
            {
                return true;
            }
        }
    }
    return false;
}

FillArray(matrix);
PrintArray(matrix);