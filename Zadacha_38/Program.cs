Console.Clear();
Console.WriteLine("Введите длину массива:");
int Lon = int.Parse(Console.ReadLine());

double[] array = new double[Lon];
Random rand = new Random();
for (int i = 0; i < Lon; i++)
    array[i] = rand.Next(-100, 100) + rand.NextDouble();
var str = string.Join(" ", array);
Console.WriteLine(str);

double max = array[0];
double min = array[0];
double dif = 0;

for (int i = 0; i < Lon; i++)
    if (max < array[i]) max = array[i];
for (int i = 0; i < Lon; i++)
    if (min > array[i]) min = array[i];

if (min < 0) min = min * -1;
dif = max - min;
if (dif < 0) dif = dif * -1;
Console.WriteLine($"Разница между максимальным и минимальным значением = {dif}");