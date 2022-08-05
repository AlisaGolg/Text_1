// task 33
Console.WriteLine("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("Введите число, которое нужно найти: ");
int m = Convert.ToInt32(Console.ReadLine());
bool flag = false;
int j = 0;
while (!flag)
{
    if (array[j] == m)
        flag = true;
    j++;
}
if (flag == false)
    Console.WriteLine("no");
else
    Console.WriteLine("yes");

