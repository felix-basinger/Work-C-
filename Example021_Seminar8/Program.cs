//  int height = new Random().Next(3,7);
// int length = new Random().Next(3,7);

// int[,] arr = FillArray(height, length);
// PrintArray(arr);
// System.Console.WriteLine();
// if(arr.GetLength(0) == arr.GetLength(1))
// {
//     ReverceArray(arr);
//     PrintArray(arr);
// }
// else
// {
//     System.Console.WriteLine("No way");
// }

// int[,] FillArray(int height, int length)
// {
//     int[,] array = new int[height, length];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(-10,11);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j] + "  ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] ReverceArray(int[,] array)
// {
//     int temp = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(j > i)
//             {
//                 temp = array[i,j];
//                 array[i,j] = array[j,i];
//                 array[j,i] = temp;
//             }
//         }
//     }
//     return array;
// }















var dictionary = new Dictionary<int, int>();
var array = GetArray(4, 4);

ShowArray(array);

foreach (var item in array)
{
	if (dictionary.ContainsKey(item))
	{
		dictionary[item]++;
	}
	else
	{
		dictionary.Add(item, 1);
	}
}

foreach (var item in dictionary.OrderBy(x => x.Key))
{
	Console.WriteLine($"{item.Key} --- {item.Value}");
}



int[,] GetArray(int length1, int length2)
{
	int[,] array = new int[length1, length2];

	for (int i = 0; i < length1; i++)
	{
		for (int j = 0; j < length2; j++)
		{
			array[i, j] = new Random().Next(0, 11);
		}
	}

	return array;
}

void ShowArray(int[,] array)
{

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j]);
		}
		Console.WriteLine();
	}
}
