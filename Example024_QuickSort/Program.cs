void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 101); // [-100; 100]
}


int SortQuick(int[] array, int start, int end)
{
    int temp;
    int marker = start;
    for (int i = start; i < end; i++)
    {
        if (array[i] < array[end])
        {
            temp = array[marker];
            array[marker] = array[i];
            array[i] = temp;
            marker += 1;
        }
    }
    temp = array[marker];
    array[marker] = array[end];
    array[end] = temp;
    return marker;
}


void recSsort(int[] array, int start, int end)
{
    if (start >= end)
    return ;
    int pivot = SortQuick(array, start, end);
    recSsort(array, start, pivot - 1);
    recSsort(array, pivot + 1, end);
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
recSsort(array, 0, array.Length - 1);
System.Console.WriteLine($"Sorted array: [{string.Join(", ", array)}]");