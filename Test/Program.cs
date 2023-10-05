void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент массива");
        string n = Console.ReadLine()!;
        array[i] = n;
    }
}


Console.WriteLine("Введите кол-во элементов массива");
int N = Convert.ToInt32(Console.ReadLine());
string[] array = new string[N];
FillArray(array);
Console.WriteLine($"первоначальный массив: [{string.Join(", ", array)}]");
