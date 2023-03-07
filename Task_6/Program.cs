// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
Console.Clear();

string res = string.Empty;
int tmp2 = 0;

string FirstNumbers(int a, int b, int n)
{
    tmp2 = a + b;
    a = b;
    b = tmp2;
    res += tmp2 + " ";
    if (n > 1) FirstNumbers(a, b, n - 1);

    return res;
}

Console.WriteLine(FirstNumbers(1,2,7));
