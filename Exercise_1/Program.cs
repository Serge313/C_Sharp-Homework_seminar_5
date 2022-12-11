TestingGetNumberOfEvens();
TestingFillArray();
int sizeOfArray = GetNumber("Enter size of your array ");
int[] array = new int [sizeOfArray];
FillArray(array);
PrintArray(array);
int count = GetNumberOfEvens(array);
Console.WriteLine($" -> {count}");


void TestingFillArray()
{
    Console.WriteLine("Testing of the \"FillArray\" method has been launched... ");
    int[] testArray = new int [10];
    FillArray(testArray);
    int tmp = 0;
    for (int i = 0; i < testArray.Length; i++)
    {
        if (testArray[i] >= 100 && testArray[i] < 1000)
        {
            tmp = 0;
        }
        else
        {
            tmp += 1;
        }
    }
    bool isPositiveAndThreeDigit = tmp == 0;
    if (isPositiveAndThreeDigit)
    {
        Console.WriteLine("Test completed successfully!");
    }
    else
    {
        Console.WriteLine("Error! Need to fix the method!");
    }
    Console.WriteLine();
}


void TestingGetNumberOfEvens()
{
    Console.WriteLine("Testing of the \"GetNumberOfEvens\" method has been launched... ");
    int[] testArray = {345, 897, 568, 234};
    int expected = 2;
    int actual = GetNumberOfEvens(testArray);
    bool isEqual = expected == actual;
    if (isEqual)
    {
        Console.WriteLine("Test completed successfully!");
    }
    else
    {
        Console.WriteLine("Error! Need to fix the method!");
    }
    Console.WriteLine();
}


int GetNumberOfEvens(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
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
        array[i] = random.Next(100, 1000);
    }
}


int GetNumber(string message)
{
    Console.Write(message);
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);
    if (isParsed)
    {
        return number;
    }
    else
    {
        Console.WriteLine("Ivalid value entered!");
        return -1;
    }
}