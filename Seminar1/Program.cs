// Console.WriteLine(" Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// x = x * x;
// Console.WriteLine($"Квадрат вашего числа {x}");

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число");
int b = Convert.ToInt32(Console.ReadLine());

int quad = b * b;
if (quad==a)
{
    Console.WriteLine($"{a} - является квадратом {b}")
}
Сonsole.WriteLine($"{a} - не является квадратом {b}")