Console.WriteLine("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
int remainder = number1 % number2;
if (number1 % number2 == 0)
{
    Console.WriteLine("Число 1 кратно числу 2");
}
else
{
    Console.WriteLine("Остаток: " + remainder);
};
    