Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int first = number / 10000;
int number2 = number / 1000;
int second = number2 % 10;
int number4 = number % 10000;
int number41 = number4 / 10;
int fourth = number41 % 10;
int number5 = number % 10000;
int number51 = number5 % 100;
int fifth = number51 % 10; 
if (first + second == fifth + fourth)
{
Console.WriteLine("Число является палиндрономом");
}
else 
{
Console.WriteLine("Число не является палиндрономом");
};
