// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму четных элементов, стоящих на нечётных позициях 
// (позиция - индекс элемента в массиве).


Console.WriteLine("Ввести длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int [] array = new int [length];

int Sum = 0;

for (int i=0; i<length; i++)
{
    array[i] = new Random().Next(1, 1000);
    Console.Write(array[i] + ",");
    if (array[i] % 2 == 0 && i % 2 != 0)
    {
        Sum = Sum + array[i];
    }
}
Console.WriteLine("Сумма четных элементов, стоящих на нечётных позициях = " + Sum);
