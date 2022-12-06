System.Console.Write("Введите координаты точки x ");
int x = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите координаты точки y ");
int y = int.Parse(Console.ReadLine()!);

if (x > 0 && y > 0)
{
Console.WriteLine("I");
}
if (x < 0 && y > 0)
{
Console.WriteLine("II");
}
if (x < 0 && y < 0)
{
Console.WriteLine("III");
}
if (x > 0 && y < 0)
{
Console.WriteLine("IV");
}

