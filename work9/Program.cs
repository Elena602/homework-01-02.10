Console.WriteLine("Введите двузначное число: ");
int number = int.Parse(Console.ReadLine());
int second = number % 10;
int first = number / 10;
if (first > second)
{
   Console.WriteLine("Первая цифра больше: " + first); 
}
else if (second > first)
{
    Console.WriteLine("Вторая цифра больше: " + second);
}
else 
{
    Console.WriteLine("Обе цифры равны");
}
