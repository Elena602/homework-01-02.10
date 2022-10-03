int Max(int number1, int number2, int number3)
{
    int result = number1;
    if (number2 > number1) result = number2;
    if (number3 > result) result = number3;
    return result;
}
Console.WriteLine("Введите число1: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число2: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число3: ");
int number3 = int.Parse(Console.ReadLine());

int result = Max(number1, number2, number3);
Console.WriteLine(result);