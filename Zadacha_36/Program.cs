Console.Clear();
Console.WriteLine("Введите длину массива:");
int Lon = int.Parse(Console.ReadLine());

int[] array = new int[Lon];
Random rand = new Random();
for (int i = 0; i < Lon; i++)
    array[i] = rand.Next(-100, 100);
var str = string.Join(" ", array);
Console.WriteLine(str);

int cht = 0;
for (int i = 0; i < Lon; i = i + 2)
 cht = array[i] + cht;
Console.WriteLine($"Сумма нечетных элементов = {cht}");