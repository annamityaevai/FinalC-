Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Введите число M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
if (M>N)
for (int i = M; i >= N; i--)
    Console.Write($" {i}");
else
    for (int i = N; i >= M; i--)
Console.Write($" {i}");