Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int number1 = number / 10;
int second = number1 % 10;
Console.WriteLine("Вторая цифра трехзначного числа: " + second);
