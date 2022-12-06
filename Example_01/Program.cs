Console.Clear ();

Console.WriteLine ("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = (a / 10) % 10;
if (a < 100 && a > 999)
    Console.WriteLine("!!! Введите ТРЕХЗНАЧНОЕ число !!!");
else
{
    Console.WriteLine ($"Вторая цифра числа: {b}");
}