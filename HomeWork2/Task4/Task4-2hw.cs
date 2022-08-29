int start = 1;
int stop = 1000000;
int Multiplicity_num1 = 7;
int Multiplicity_num2 = 23;
int Multiplicity_numders = 7 * 23;

int RandomNum = new Random().Next(start, stop);

int Result = RandomNum % Multiplicity_numders;

if (Result == 0)
{
    Console.WriteLine("Число Кратно и = " + RandomNum);
}
else
{
    Console.WriteLine("Число НеКратно и = " + RandomNum);
}
