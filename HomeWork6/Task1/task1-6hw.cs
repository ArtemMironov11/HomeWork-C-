// Программа запрашивает натуральное число M, 
// пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


//Random number М
int M = new Random().Next(1, 11);

Console.WriteLine("Вводите числа " + M + " раз: ");

int[] array = new int [M];

for (int i = 0; i < M; i++)
{
   array[i] = Convert.ToInt32(Console.ReadLine());
}
int count = 0;

for (int i = 0; i < M; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine(count);
