Console.WriteLine("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("Диапазоны для возможных координат: x > 0, y > 0");
};
if (number == 2)
{
    Console.WriteLine("Диапазоны для возможных координат: x < 0, y > 0");
};
if (number == 3)
{
    Console.WriteLine("Диапазоны для возможных координат: x < 0, y < 0");
};
if (number == 4)
{
    Console.WriteLine("Диапазоны для возможных координат: x > 0, y < 0");
};