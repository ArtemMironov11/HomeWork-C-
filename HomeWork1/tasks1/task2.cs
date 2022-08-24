//задача 4 (2)
string number = Console.ReadLine();
int num1 = Convert.ToInt32(number);

string number1 = Console.ReadLine();
int num2 = Convert.ToInt32(number1);

string number2 = Console.ReadLine();
int num3 = Convert.ToInt32(number2);

int num_max = num1;
if (num1 >= num2)
{
    num_max = num1;
}
else
{
    num_max = num2;

    if (num_max >= num3)
    {
        Console.WriteLine(num_max);
    }
    else
    {
        num_max = num3;
        Console.WriteLine(num_max);
    }
}


