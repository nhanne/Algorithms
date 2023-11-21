
Console.Title = "Algorithms";


var numbers = new[] { 10, 3, 1, 7, 9, 2, 0 };
Console.WriteLine("Selection Sort");
SelectionSort(numbers);

numbers = new[] { 9, 1, 5, 2, 4, 6, 3 };
Console.WriteLine("Insertion Sort");
InsertionSort(numbers);

numbers = new[] { 3, 7, 4, 1, 5, 8 };
Console.WriteLine("Bubble Sort");
BubbleSort(numbers);
Console.ReadKey();
static void Swap<T>(T[] array, int i, int m)
{
    T temp = array[i];
    array[i] = array[m];
    array[m] = temp;
}
static void Print<T>(T[] array)
{
    Console.WriteLine(string.Join("\t", array));
}
static void SelectionSort<T>(T[] array) where T : IComparable
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int m = i;
        T minValue = array[i];
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j].CompareTo(minValue) < 0)
            {
                m = j;
                minValue = array[j];
            }
        }
        Swap(array, i, m);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Step {i + 1}: i = {i}, m = {m}, min = {minValue}");
        Console.ResetColor();
        Print(array);
        Console.WriteLine();
    }
}
static void InsertionSort<T>(T[] array) where T : IComparable
{
    for (var i = 1; i < array.Length; i++)
    {
        var j = i;
        while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
        {
            Swap(array, j, j - 1);
            j--;
        }
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Step {i}: \t");
        Console.ResetColor();
        Print(array);
        Console.WriteLine();
    }
}
static void BubbleSort<T>(T[] array) where T : IComparable
{
    for (var i = 0; i < array.Length - 1; i++)
    {
        var hasChanged = false;
        for (var j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j].CompareTo(array[j + 1]) > 0)
            {
                hasChanged = true;
                Swap(array, j, j + 1);
            }
        }
        if (!hasChanged)
        {
            break;
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Step {i + 1}: \t");
        Console.ResetColor();
        Print(array);
        Console.WriteLine();
    }
}


