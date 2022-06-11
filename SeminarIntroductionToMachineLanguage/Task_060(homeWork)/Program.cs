// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

Console.WriteLine($"\nВведите размер массива X x Y x Z:");
Console.Write("Введите X: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите Y: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите Z: ");
int z = int.Parse(Console.ReadLine());

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

void WriteArray (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] arr)
{
  int[] temp = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < arr.GetLength(0); x++)
  {
    for (int y = 0; y < arr.GetLength(1); y++)
    {
      for (int z = 0; z < arr.GetLength(2); z++)
      {
        arr[x, y, z] = temp[count];
        count++;
      }
    }
  }
}