void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент массива");
        string n = Console.ReadLine()!;
        array[i] = n;
    }
}

string[] ModifiedArray(string[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            j++;
    }
    string[] modifiedArray = new string[j];
    j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            modifiedArray[j] = array[i];
            j++;
        }
    }
    return modifiedArray;
}

Console.WriteLine("Введите размер массива");
int syze = Convert.ToInt32(Console.ReadLine());
string[] array = new string[syze];
FillArray(array);
Console.WriteLine($"первоначальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"измененный массив: [{string.Join(", ", ModifiedArray(array))}]");