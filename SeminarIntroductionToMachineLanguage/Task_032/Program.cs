﻿// Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
var newRnd = new Random();

Console.WriteLine("Исходный массив:");
for (int i = 0; i < size; i++)
{
    array[i] = newRnd.Next(-9, 25);
    Console.Write(array[i] + " ");
}

Console.WriteLine();
Console.WriteLine("Инвертированый массив:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * (-1);
    Console.Write(array[i] + " ");
}

