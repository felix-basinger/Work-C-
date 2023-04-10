// int Length = ReadInt("длину массива");
// int min = ReadInt("минимальное значение массива");
// int max = ReadInt("максимальное значение массива");
// int [] numbers = CreateArray(Length, min, max);
// PrintArray(numbers);
// Reverse(numbers);
// PrintArray(numbers);

// int ReadInt(string arg)
// {
//     System.Console.Write($"Введите {arg}: ");
//     return int.Parse(Console.ReadLine());
// }

// int [] CreateArray(int Length, int min, int max)
// {
//     int [] numbers = new int [Length];

//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(min, max);
//     }
//     return numbers;
// }

// void Reverse(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length/2; i++)
//     {
//         int temp = numbers[i];
//         numbers[i] = numbers[numbers.Length-1-i];
//         numbers[numbers.Length-1-i] = temp;
//     }
// }

// void PrintArray(int[] numbers)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < numbers.Length-1; i++)
//     {
//         System.Console.Write(numbers[i] + "; ");
//     }
//     System.Console.WriteLine(numbers[numbers.Length-1]+ "]");
// }














// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.



// int ReadInt (string argument)
// {
//     System.Console.WriteLine(argument);
//     return int.Parse(Console.ReadLine());
// }

// void Triangle(int a, int b, int c)
// {
    
//      if(a+b>c && b+c>a && c+a>b)
//      {
//         System.Console.WriteLine("Такой треугольник существует;)");
//      }
//      else
//      {
//         System.Console.WriteLine("Такого треугольника несуществует(");
//      }

// }
// int a = ReadInt($"Введите первое число: ");
// int b = ReadInt($"Введите второе число: ");
// int c = ReadInt($"Введите третье число: ");

// Triangle(a,b,c);










// Задача 42: Напишите программу, которая будет преобразовывать десятичное число
// в двоичное.45 -> 1011013 -> 112 -> 10

// int ReadInt (string argument)
// {
//     System.Console.WriteLine(argument);
//     return int.Parse(Console.ReadLine());
// }


// int a = ReadInt($"Введите десятичное число: ");

// string Preob(int a)
// {
//     // string result = " "; 
//     string result = "";
//     for (int i = a; i > 0; i/=2)
//     {
//         result += i % 2;
         
//     }
//     return result;
// }


// string Reverse(string result)
// {
//     string newresult = "";
//     for (int i = 0; i < result.Length; i++)
//     {

//         newresult += result[result.Length-1-i];
//     }
//     return newresult;
// }


// // System.Console.WriteLine(Preob(a));
// string result = Preob(a);
// System.Console.WriteLine(Reverse(result));













// PrintArray(Array(Read()));

// int Read ()
// {
//     System.Console.Write("Введите число N: ");
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// int [] Array(int number)
// {
//     int [] array = new int [number];
//     array[0] = 0;
//     array[1] = 1;
//     for (int i = 2; i < number; i++)
//     {
//         array[i] = array[i-2] + array[i-1];
//     }
//     return array;
// }

// void PrintArray(int [] array)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < array.Length-1; i++)
//     {
//         System.Console.Write(array[i] + "; ");
//     }
//     System.Console.Write(array[array.Length-1] + "]");
// }














int [] array = {1, 56, 0, 7, 7};



int [] Numbers(int [] array)
{
    int [] numbers = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        numbers [i] = array[i];
    }
    return numbers;
}

System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine(string.Join(", ", Numbers(array)));
