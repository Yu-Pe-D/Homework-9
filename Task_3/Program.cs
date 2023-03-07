// Найти сумму цифр числа
Console.Clear();
Console.Write("Введите целое число: ");

 int a = int.Parse(Console.ReadLine());
            int s = 0;
            while (a > 0)
            {
 
                s = s + a % 10;
                a = a /10 ;
 
            }
 Console.WriteLine();
 Console.WriteLine(s);
 Console.WriteLine();
