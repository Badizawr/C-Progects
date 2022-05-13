int[] array = { 12, 26, 36, 40, 85, 76, 67, 58, 59, 11 };

int n = array.Length;
int find = 11;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}