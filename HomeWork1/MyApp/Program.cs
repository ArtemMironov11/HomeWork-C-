//задача 2 (1)
string number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);

string number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);

if (a >= b)
{
    Console.WriteLine("Max = " + a);
}
else
{
    Console.WriteLine("Max = " + b);
}