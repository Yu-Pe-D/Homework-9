// Написать программу возведения числа А в целую стень B

Console.Clear();
Console.Write("Введите число: ");
double A = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите степень в виде целого числа: ");

double B = double.Parse(Console.ReadLine());
A = Math.Pow(A, B);
Console.WriteLine();
Console.WriteLine("равно "+A+"");
Console.WriteLine();