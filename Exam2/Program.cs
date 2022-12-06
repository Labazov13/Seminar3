System.Console.WriteLine("Введите номер четверти");
int num=int.Parse(Console.ReadLine()!);

if(num>4){
System.Console.WriteLine("Такой плоскости не существует!");
}
if(num==1){
System.Console.WriteLine("Координаты X: от 0 до +бесконечности. Координаты Y: от 0 до +бесконечности");
}
if(num==2){
System.Console.WriteLine("Координаты X: от 0 до -бесконечности. Координаты Y: от 0 до +бесконечности");
}
if(num==3){
System.Console.WriteLine("Координаты X: от 0 до -бесконечности. Координаты Y: от 0 до -бесконечности");
}
if(num==4){
System.Console.WriteLine("Координаты X: от 0 до +бесконечности. Координаты Y: от 0 до -бесконечности");
}