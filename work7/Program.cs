Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int number1 = number % 100;
int third = number1 % 10;
Console.WriteLine("Последняя цифра трехзначного числа: " + third);
