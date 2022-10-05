Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int first = number / 100;
int number2 = number / 10;
int second = number2 % 10;
int number3 = number % 100;
int third = number3 % 10;
Console.WriteLine("Двухзначное число: " + first + third);
