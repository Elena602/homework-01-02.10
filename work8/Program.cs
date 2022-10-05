Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int second = number / 10;
int number2 = second % 10;
Console.WriteLine("Вторая цифра трехзначного числа: " + number2);
