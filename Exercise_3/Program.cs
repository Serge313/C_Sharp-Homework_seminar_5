Random random = new Random();
int randomSizeOfArray = random.Next(3, 10);
int[] array = new int [randomSizeOfArray];
FillArray(array);
PrintArray(array);
Console.WriteLine($" -> {FindDifferenceBetweenMaxAndMinNumber(array)}");


int FindDifferenceBetweenMaxAndMinNumber(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= max)
        {
            max = array[i];
        }
        if (array[i] <= min)
        {
            min = array[i];
        }
    }
    return (max - min);
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    if (i < array.Length - 1)
    {
        Console.Write($"{array[i]}, ");
    }
    else
    {
        Console.Write(array[i]);
    }
}


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 100);
    }
}