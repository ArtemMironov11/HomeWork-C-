// Задайте произвольный целочисленный массив. Напишите программу, 
// которая определяет, присутствует ли заданное пользователем число в массиве. 

// Примечание
// Проверку принадлежности числа массиву реализовать в отдельной функции

int N = 12;
int[] numbers = new int[N];

Console.Write("Ввседите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int N = 0;
// N = randStop - randStop;

Random rnd = new Random();

for(int i = 0; i < N; i++)
{
    numbers[i] = rnd.Next(-9, 9+1);
}

void task(int num)
{
    for(int i = 0; i < N; i++)
    {
        if (num == numbers[i])
        {
            Console.Write($"Число {num} совпадает с числом из массива\n");
            break;
        }
        else 
        {
            if (num != numbers[i])
            {
                Console.WriteLine($"Число {num} не найдено в массиве\n");
                break;
            }
        }
    }
}

task(num);