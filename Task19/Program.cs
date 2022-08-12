Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
if (number[0]==number[4] && number[1]==number[3])
{
    Console.WriteLine("Да, это палиндром");
}
else
{
    Console.WriteLine("Нет, это не палиндром");
}


