// // task 32
Console.WriteLine("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("[" + string.Join(", ", array) + "]");

for (int i = 0; i < n; i++)
    array[i] *= (-1);

Console.WriteLine("[" + string.Join(", ", array) + "]");

