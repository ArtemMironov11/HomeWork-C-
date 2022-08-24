//задача 8 (4) - hard level for me =)


string number1 = Console.ReadLine();
int num = Convert.ToInt32(number1);

for (int input = 1; input < num+1; input++)
{
    if (input % 2 == 0)
    {
        Console.Write(input + " ");
    }
}
