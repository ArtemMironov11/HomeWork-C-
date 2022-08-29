int start = 100;
int stop = 1000;
int RandomNum = new Random().Next(start, stop);

int Digit_first = RandomNum / 100;
int Number = RandomNum / 10;
int digit_second = Number - Digit_first * 10;

Console.WriteLine (RandomNum);
Console.WriteLine (digit_second);