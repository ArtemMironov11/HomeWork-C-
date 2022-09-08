// Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Ввести длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int [] array = new int [length];

int MinNum = 999;
int MaxNum = 0;
int difference = 0;

for (int i=0; i<length; i++)
{
    array[i] = new Random().Next(1, 1000);
    Console.Write(array[i] + ",");
    if (array[i]>MaxNum)
    {
        MaxNum = array[i];
    }
    else
    if (array[i]<MinNum)
    {
        MinNum = array[i];
    }
}
difference = MaxNum - MinNum;
Console.WriteLine("Разница между максимальным и минимальным элементами массива = " + difference);
