// Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());

// int quad = b * b;

// if (quad==a)
// {
//     Console.WriteLine($"{a} - является квадратом {b}");
// }
// else
// {
//     Console.WriteLine($"{a} - не является квадратом {b}");
// }

// Console.WriteLine ("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// int LowerBorder = -N;

// while (LowerBorder <= N)
// {
//     Console.WriteLine($"{LowerBorder}");
//     LowerBorder = LowerBorder + 1;
// }

Console.WriteLine("Введите трехзначное число");
int x = Convert.ToInt32(Console.ReadLine());

int ostatok = x % 10;

Console.WriteLine($"{ostatok}");