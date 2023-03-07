// Показать натуральные числа от M до N, N и M заданы

Console.Write("Введи N: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введи M: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
if (M>N)
for (int i = N; i <= M; i++)
    Console.Write($" {i}");
else
    for (int i = M; i <= N; i++)
        Console.Write($" {i}");