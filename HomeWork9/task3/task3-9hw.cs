// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// Функция Аккермана для m = 0
int AckermannFunctionM0(int n)          
{
    return n + 1;
}

// Функция Аккермана для m > 0 и n = 0
int AckermannFunctionN0(int m, int n) 
{  
    if(m == 0)
    {
        return AckermannFunctionM0(n);
    }

    return AckermannFunction(m - 1, 1);
}

// Функция Аккермана для m > 0 и n > 0
int AckermannFunction(int m, int n)     
{
    if(m == 0)
    {
        return AckermannFunctionM0(n);
    }
    if(n == 0)
    {
        return AckermannFunctionN0(m, n);
    }
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

int EnteringM()
{
    Console.Write("Введите число m : ");
    int m = Convert.ToInt32(Console.ReadLine());
    return m;
}

int EnteringN()
{
    Console.Write("Введите число n : ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

int m = EnteringM();
int n = EnteringN();

bool checkInputData1 = false;
bool checkInputData2 = false;
while(checkInputData1 != true || checkInputData2 != true)
{
    if(m < 0 || n < 0)
    {
        Console.WriteLine("Числа должны быть больше 0");
        m = EnteringM();
        n = EnteringN();
    }
    else
    {
        checkInputData1 = true;
    }
    // На моем компьютнон при больших значениях стек переполнялся
    if(m > 3 || n > 11)         
    {
        if(m == 4 && n == 0)
        {
            break;
        }
        Console.WriteLine("Вычисление функции переполнит стек");
        m = EnteringM();
        n = EnteringN();
    }
    else
    {
        checkInputData2 = true;
    }
}

Console.WriteLine(AckermannFunction(m, n));
