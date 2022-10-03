Console.WriteLine("Введите число1: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число2: ");
int number2 = int.Parse(Console.ReadLine());
int kvadrat = number2*number2;
if (number1 == kvadrat)
{
    Console.WriteLine("Число1 является квадратом числа2");
}
else
Console.WriteLine("Число1 не является квадратом числа2");