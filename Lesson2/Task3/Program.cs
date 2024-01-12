//int n = 10;
int[] array = {1, 10, 2, 3, 4, 55, 66, 6, 7, 88, };
int i = 0;

while (i < array.Length) 
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i++;
}

