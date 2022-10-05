Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int M = N * (-1);
while (M <= N)
{
    Console.WriteLine(M);
    M++;
};