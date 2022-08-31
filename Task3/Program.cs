Console.WriteLine("Введите число:");
double n = double.Parse(Console.ReadLine());

Console.Write(n + " -> ");

n = Math.Abs(n);

for (int i = 1; i <= n; i++)
{
    Console.Write(Math.Pow(i, 3) + ", ");
} 