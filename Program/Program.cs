void PrintArray(string[] arr)
{
    Console.Write("[" + arr[0] + " ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i]);
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}

Console.WriteLine("Введите колличество элементов, которые вы собираетесь ввести далее: ");
int size = int.Parse(Console.ReadLine() ?? "0");

string[] array = new string[size];
int position = 0;
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1}-й элемент");
    string element = Console.ReadLine() ?? "0";
    if (element.Length <= 3)
    {
        array[position] = element;
        position++;
    }
}
Console.WriteLine();
PrintArray(array);