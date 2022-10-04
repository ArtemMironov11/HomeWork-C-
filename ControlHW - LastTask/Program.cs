// let's do it!)

string[] array = new string[9] {"2", "hello", "world", ";-)", "BLA-BLA", "1", "1234", "BLA", "WTStriiiing"};
string[] array_1 = new string[array.Length];

void array_fill(string[] array, string[] array_1)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array_1[count] = array[i];
        count++;
        }
    }
}
void array_print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
array_fill(array, array_1);
array_print(array_1);