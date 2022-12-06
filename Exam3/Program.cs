System.Console.WriteLine("Вводим координаты первой точки: ");
System.Console.Write("Введите координаты точки x,y: ");
float x = float.Parse(Console.ReadLine()!);
float y = float.Parse(Console.ReadLine()!);

System.Console.WriteLine("Вводим координаты второй точки: ");
System.Console.Write("Введите координаты точки x,y: ");
float x1 = float.Parse(Console.ReadLine()!);
float y1 = float.Parse(Console.ReadLine()!);
float diffx = (x - x1);
float kvatratx = MathF.Pow(diffx, 2);
float diffy = (y - y1);
float kvatraty = MathF.Pow(diffy, 2);
float sum = kvatratx + kvatraty;
Console.WriteLine(MathF.Sqrt(sum));


