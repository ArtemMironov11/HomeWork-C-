int number1_65536 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Random_Number1__65536 " + number1_65536);

if (number1_65536 / 100 > 0)
{
    Console.WriteLine ("3rd_Digit is " + (number1_65536 / 100 % 10));
}
else
{
    Console.WriteLine("3rd_digit Absent");
}