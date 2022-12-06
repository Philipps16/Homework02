Console.Clear();
Console.WriteLine ("Введите номер дня недели: ");
int n = Convert.ToInt32 (Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write ("Вы ошиблись! Введите новое число: ");
n = Convert.ToInt32(Console.ReadLine());
};
if (n < 6)
{
    Console.WriteLine("Это рабочий день");
}    
else
    Console.WriteLine("Это выходной!!!!!");