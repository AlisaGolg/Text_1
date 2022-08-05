﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

int n = 123;
int[] array_first = new int[n];
int count = 0;
for (int i = 0; i < n; i++)
{
    array_first[i] = new Random().Next(-200, 201);
    if (array_first[i] >= 10 && array_first[i] <= 99)
        count++;
}
Console.WriteLine("[" + string.Join(", ", array_first) + "]");
Console.WriteLine(count);

