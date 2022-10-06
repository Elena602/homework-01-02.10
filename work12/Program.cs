Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int lastNumber = (number % 10);
if (number / 100 > 0)
{
    Console.WriteLine("Третья цифра числа это: " + lastNumber);
}
else 
Console.WriteLine("У числа нет третьей цифры");