// create array
int number_of_5 = Convert.ToInt32(Console.ReadLine());
int [] array = new int [5];
array [0] = number_of_5 / 10000; // 12321 / 10000 = 1
array [4] = number_of_5 % 10; // 12321 % 10 = 1
array [1] = (number_of_5/1000 - array [0] * 10); //(12321/1000 - 1*10) = 12 - 10 = 2
array [3] = number_of_5 % 100 / 10; // 12321%100/10 = 21/10 = 2

Console.WriteLine ("Random_Num_of_5 " + number_of_5);

if ((array[0] == array[4]) && (array [1] == array [3]))
{
    Console.WriteLine(array + "=> Yes, it's PAL");
}
else
{
    Console.WriteLine(array + "=> No, is not a PAL");
}
