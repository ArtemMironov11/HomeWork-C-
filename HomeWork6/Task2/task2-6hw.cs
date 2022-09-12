// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// Рекомендую учесть три возможных случая расположения двух прямых.


Console.WriteLine("Введите значение чисел k1, b1, k2, b2: ");
double k1 = Convert.ToInt32(Console.ReadLine()); double b1 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine()); double b2 = Convert.ToInt32(Console.ReadLine());

// вводим x, y1, y2 и решаем
// y1 = k1 * x + b1, y2 = k2 * x + b2; 
double x = 0;
double y1 = 0;
double y2 = 0;
x = (b2 - b1) / (k1 - k2);
Console.WriteLine("X = " + x);
y1 = k1 * x + b1;
y2 = k2 * x + b2;
Console.WriteLine("(" + y1 + ";" + y2 + ")");

// проверяем на пересечение
if ((k1 * b2 - k2 * b1) == 0)
{
    Console.WriteLine("Прямые параллельны другу друг и не имеют точек пересечения");
}
else if ((k1 * k2 + b1 * b2) == 0)
{
    Console.WriteLine("Прямые перпендикулярны");
}