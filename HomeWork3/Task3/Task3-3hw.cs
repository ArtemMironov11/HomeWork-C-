// create array
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];
//массив
int index = 0;
int Number = 1;
while (index < N)
{
    array [index] = Number * Number * Number;
    Console.Write(array[index] + " ");
    Number++;
    index++;
}
