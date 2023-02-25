// Напишите метод, который задаёт массив из N элементов и выводит их на экран.

int Number(string arg)
{
    Console.Write(arg);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

int[] CreateArray(int count, int min, int max)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
}

int l = Number("Введите длину массива: ");
int min = Number("Первое значение: ");
int max = Number("Последнее значение: ");
int[] massive = CreateArray(l, min, max);
PrintArray(massive);