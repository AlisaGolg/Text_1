// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array_first = new int[n];
int m;
if (n % 2 == 0)
    m = n / 2;
else
    m = n / 2 + 1;
int[] array_second = new int[m];
for (int i = 0; i < n; i++)
    array_first[i] = new Random().Next(1, 11);
Console.WriteLine("Исходный массив: [" + string.Join(", ", array_first) + "]");
Console.WriteLine();
for (int i = 0; i < array_second.Length; i++)
{
    array_second[i] = array_first[i] * array_first[n - 1 - i];
}
Console.WriteLine("Конечный массив: [" + string.Join(", ", array_second) + "]");
