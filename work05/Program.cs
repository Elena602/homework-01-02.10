Console.WriteLine("Введите x точки А: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y точки А: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z точки А: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите x точки B: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y точки B: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z точки B: ");
int z2 = int.Parse(Console.ReadLine());
double d = Math.Sqrt(( x1 - x2 ) * ( x1 - x2) + ( y1 - y2 ) * ( y1 - y2 ) + ( z1 - z2 ) * ( z1 - z2 ));
Console.WriteLine("Расстояние равно: " + d);
// при расчете расстояния в 3D z=0, все остальное считается так же, как и в 2D