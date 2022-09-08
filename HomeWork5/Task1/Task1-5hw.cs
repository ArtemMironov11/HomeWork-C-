// Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


// create new array
int start  = 100;
int stop = 1000;
int count = 0;

Console.WriteLine("Ввести длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int [] array = new int [length];

// Starting
for (int i=0; i<length; i++)
{
    array[i] = new Random().Next(start, stop);
    Console.Write(array[i] + ",");
    if (array[i] %2 == 0){count += 1;}
}

Console.WriteLine("Колическтво четных чисел в массиве = " + count);
