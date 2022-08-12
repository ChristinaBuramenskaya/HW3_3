Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int count = 1;
double result = 0;

while (count <= x)
{
    result = Math.Pow(count, 3);
    Console.WriteLine(result);
    count++;
}
