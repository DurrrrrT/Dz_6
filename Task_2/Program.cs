// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем или задаются вручную.


Console.WriteLine("Введите значения ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значения ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значения ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значения ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2) Console.WriteLine("Прямые параллельны ");

else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine("Коорднаты x " + x);
    Console.WriteLine("Коорднаты y " + y);
}

