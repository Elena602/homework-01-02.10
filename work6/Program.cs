Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int M = 1;

while (M <= N)
{
   if (M % 2 == 0)
   {
    Console.WriteLine("Четные числа: " + M);
   } 
   M++;
};



