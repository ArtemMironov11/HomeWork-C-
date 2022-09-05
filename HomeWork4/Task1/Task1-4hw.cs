
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Create numbers A & B

int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int i = 0;
// Checking for 0

if (B == 0)
{
    A = A^B;
    Console.WriteLine("Result = " + A);
}
else 
{
    int tmp = A;
    for (i = 0; i < B-1; i++)
    {
        A = A * tmp;
    }
    Console.WriteLine("Result = " + A);
}