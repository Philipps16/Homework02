Console.Clear ();


Console.WriteLine("Введите размер массива (более 3 чисел)");
int n = Convert.ToInt32 (Console.ReadLine());
if (n < 3)
{
    Console.WriteLine ("Попробуйте снова");
    n = Convert.ToInt32 (Console.ReadLine());
}

int[] array = new int [n];
Random rand = new Random();
int x = 0;
int first_max = array[x];
for (int i = 0; i < array.Length; i++)
{

        array[i] = rand.Next (1, 100);
        array [n-1] = 0;
        Console.Write($"{array [i]}, ");
}

while (x < n)
{
    if (array[x] > first_max)
    first_max = array[x];
    x++;
}

int z = 0;
while (z < n)
{
    if (array[z] == first_max)
    {
        int h = array [n-2];
        array [n-2] = first_max;
        array [z] = h;
    }
    z++;
}
int y = 0;
int second_max = array [y];
while (y < (n - 2))
{
    if (array[y] > second_max)
    second_max = array[y];
    y++;
}
Console.Write("Второе максимальное число: ");
Console.WriteLine(second_max);

