// int Num(string arg)
// {
//     System.Console.WriteLine($"Enter {arg}");
//     return int.Parse(Console.ReadLine());
// }

// int[] CreateArray(int length, int min, int max)
// {
//     int[] nums = new int [length];
//     for (int i = 0; i < nums.Length; i++)
//     {
//         nums[i] = new Random().Next(min, max + 1);
//     }
//     return nums;
// }

// void PrintArray(int[] nums)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < nums.Length - 1; i++)
//     {
//         System.Console.Write(nums[i] + "; ");
        
//     }
//     System.Console.WriteLine(nums[nums.Length - 1] + "]");
// }

// int PositiveSum(int[] nums)
// {   
//     int sum = 0;
//     for (int i = 0; i < nums.Length; i++)
//     {
//         if(nums[i] > 0)
//         {
//             sum += nums[i];
//         }
//     }
//     return sum;
// }

// int NegativeSum(int[] nums)
// {   
//     int sum = 0;
//     for (int i = 0; i < nums.Length; i++)
//     {
//         if(nums[i] < 0)
//         {
//             sum += nums[i];
//         }
//     }
//     return sum;
// }

// int length = Num("the length of array");
// int min = Num("min num in array");
// int max = Num("max num of length");

// int [] numb = CreateArray(length, min, max);
// PrintArray(numb);
// System.Console.WriteLine(PositiveSum(numb));
// System.Console.WriteLine(NegativeSum(numb));  











// using System;
// DateTime now = DateTime.Now;

// int k = 5;
// int b = 4;

// int x0 = 3;
// int xLast = 150000;
// double offset = 0.00001;

// double result = 0;
// int count = 0;
// for (double i = x0; i < xLast; i+= offset)
// {
//     double rectangleSquare = ((offset + i) * k + b) * offset;
//     result += rectangleSquare;
//     count ++;
// }
// DateTime end = DateTime.Now;
// System.Console.WriteLine(result);
// System.Console.WriteLine(count);
// System.Console.WriteLine(end - now);









int CreateArray(){
    System.Console.Write("Введите длину массива: ");
    int x = int.Parse(System.Console.ReadLine());
    return x;
}

int[] Array = new int[CreateArray()];

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(-100,201);
    System.Console.Write($"{Array[i]}; ");
}

void Task(int[] Array){

    int count = 0;

    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] >= 10 && Array[i] <= 99){
            count++;
        }
    }

System.Console.WriteLine(count);

}
System.Console.WriteLine(" ");
Task(Array);
