Console.Clear();
Console.WriteLine ("Введите число: ");
int n = Convert.ToInt32 (Console.ReadLine());
int b = 0;
if (n < 100)
    Console.WriteLine ("Третьей цифры нет");
else
{
while (n > 999)
    n = n / 10;
    b = n % 10;     

Console.WriteLine ($"Третья цифра: {b}");
}