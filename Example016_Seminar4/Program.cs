// int Start()
// {
//     System.Console.WriteLine("Enter the number: ");
//     int a = int.Parse(Console.ReadLine());
//     return a;
// }

// int a = Start();

// int Sum(int a)
// {
//     int result = 0;
//     for (int i = 1; i <= a; i++)
//     {
//         result += i;  
//     }    
//     return result;
// }
 
//  int result = Sum(a);
//  System.Console.WriteLine(result);












 // принимает число и выдаёт количество символов(цифр)

// int Read()
// {
//     System.Console.WriteLine("Input number: ");
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// int number = Read();
// System.Console.WriteLine();
// string num = number.ToString();

// if (number>0)
// {
//     System.Console.WriteLine(num.Length);
// }
// else
// {
//     System.Console.WriteLine(num.Length-1);
// }











// int ReadInt()
// {
//     int number;
//     System.Console.WriteLine("Input an integer number: ");
//     while(!int.TryParse(Console.ReadLine(), out number) || number < 0)
//     {
//         System.Console.WriteLine("It's not that");
//     }
//     return number;
// }

// Task();

// void Task()
// {
//     int N = ReadInt();
//     double result = 1;
//     for(int i = 1; i <= N; i++)
//     {
//         result *=i;
//     }
//     System.Console.WriteLine(result);
// }










// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

// int [] numbers = new int[8];
// int length = numbers.Length;

// Method (length);
// void Method (int length)

// {
//     for (int i = 0; i < length; i++)
//     {
//        numbers [i] = new Random().Next(0,2);
//        System.Console.Write(numbers [i]);
//     }
// }









int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{

  array[i] = new Random().Next(0,2);

}


Console.WriteLine(string.Join(", ",array));
