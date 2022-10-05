Console.WriteLine("Введите число1: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число2: ");
int number2 = int.Parse(Console.ReadLine());
int kvadrat1 = number1*number1;
int kvadrat2 = number2*number2;
if (number1 == kvadrat2)
{
    Console.WriteLine("Число1 является квадратом числа2");
}
else
Console.WriteLine("Число1 не является квадратом числа2");
if (number2 == kvadrat1)
{
    Console.WriteLine("Число2 является квадратом числа1");
}
else
Console.WriteLine("Число2 не является квадратом числа1");
