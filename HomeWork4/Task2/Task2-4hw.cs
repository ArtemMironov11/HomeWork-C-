// Задача 2:* Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе, 
// которые являются делителями этого числа. 
// (для получения цифр числа операцию приведения числа к строке не использовать)

// Create numbers A

int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

if (num > 0)
{
    int tmp1 = num;
    while (tmp1 > 0)
    {
        int digit = tmp1%10;
        tmp1 = tmp1 / 10;
        if (digit != 0)
        {
            if (num % digit == 0)
            {
            sum = sum + digit;
            }
            
        }
    }
    Console.WriteLine ("Summ = " + sum);
}
else 
{
    sum = num;
    Console.WriteLine ("Summ " + sum);
}