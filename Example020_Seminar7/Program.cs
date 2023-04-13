// System.Console.WriteLine("Array");
// int[] array = ReadArray();

// System.Console.WriteLine(string.Join("; ", array));


// int[] ReadArray()
// {
//     string arrayAsString = Console.ReadLine();

//     string[] numbersAsString = arrayAsString.Split(", ");

//     int[] array = new int[numbersAsString.Length];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = int.Parse(numbersAsString[i]);
//     }
//     return array;
// }









// int[,] CreateArray(int length1, int length2)
// {
//     int[,] Array = new int[length1, length2];

//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Array[i, j] = new Random().Next(-100,100);
//         }
//     }
//     return Array;
// }

// void PrintArray(int[,] Array)
// {
//      for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             System.Console.Write(Array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// PrintArray(CreateArray(4, 4));













// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
//Aₘₙ = m+n. Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5

int [,] CreatArray(int length1, int length2)
{
    int [,] array = new int [length1, length2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i + j;
        }
    }
    return array;
}

void PrintArray(int [,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}

int ReadInt()
{
    System.Console.WriteLine("Введите число: ");
    return int.Parse(Console.ReadLine());
}

int length1 = ReadInt();
int length2 = ReadInt();
PrintArray(CreatArray(length1, length2));
