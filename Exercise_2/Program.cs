Random rnd = new Random();
int randomSizeOfArray = rnd.Next(1, 20);
int[] array = new int [randomSizeOfArray];
FillArray(array);
PrintArray(array);
Console.WriteLine($" -> {GetSumOfOddIndex(array)}");


int GetSumOfOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }
}


void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 101);
    }
}


// int GetNumber(string message)
// {
//     Console.Write(message);
//     bool isParsed = int.TryParse(Console.ReadLine(), out int number);
//     if (isParsed)
//     {
//         return number;
//     }
//     else
//     {
//         Console.WriteLine("Invalid value entered!");
//         return -1;
//     }
// }