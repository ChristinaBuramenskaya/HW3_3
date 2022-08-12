Console.WriteLine("Введите x первой точки");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y первой точки");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z первой точки");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x второй точки");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y второй точки");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z второй точки");
int zB = Convert.ToInt32(Console.ReadLine());

double S=(Math.Sqrt(Math.Pow((xB-xA),2)+Math.Pow((yB-yA),2)+Math.Pow((zB-zA),2)));
Console.WriteLine(S);