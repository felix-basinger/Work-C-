// void SayHelloRu()
// {
//     Console.WriteLine("Привет");
// }
// void SayHelloEn()
// {
//     Console.WriteLine("Hello");
// }
// void SayHelloFr()
// {
//     Console.WriteLine("Bonjour");
// }

// string language = "fr";

// switch(language)
// {
//     case "en":
//         SayHelloEn();
//         break;
//     case "ru":
//         SayHelloRu();
//         break;
//     case "fr":
//         SayHelloFr();
//         break;
// }

// int [] array = new int[10];

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while(index < length)
//     {
//         collection[index] = new Random().Next(1, 100);
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while(position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// FillArray(array);
// PrintArray(array);









// Main();

// void Main()
// {
// 	bool isWorking = true;

// 	while (isWorking)
// 	{
// 		Console.WriteLine("Input task");

// 		string task = Console.ReadLine();

// 		switch (task)
// 		{
// 			case "exit": isWorking = false; break;
// 			case "t1": Task1(); break;
// 			default:
// 				break;
// 		}
// 	}
// }

// void Task1()
// {
// 	int a = ReadInt("a");
// 	int b = ReadInt("b");
// 	int less = a;

// 	if (IsMoreThen(a, b))
// 	{
// 		less = b;
// 	}

// 	Console.WriteLine(less);
// }

// int ReadInt(string argument)
// {
// 	int number;

// 	Console.Write($"Input {argument}:");

// 	while (!int.TryParse(Console.ReadLine(), out number))
// 	{
// 		Console.WriteLine("It's not a number!");
// 	}

// 	return number;
// }

// bool IsMoreThen(int a, int b)
// {
// 	return a > b;
// }






// Main();

// void Main() 
// {
//     bool Work = true;
//     while (Work)
//     {
//         System.Console.WriteLine("Решаем задачу? Введите y/n.");
//         string a = System.Console.ReadLine();
//         switch (a) 
//         {
//             case "y":task1();break;
//             case "n": Work = false; break;
//         }

//     }
// }

// void task1()
// {
//     System.Console.WriteLine("1 порог");
//     int num1 = int.Parse(Console.ReadLine());
//     System.Console.WriteLine("2 порог");
//     int num2 = int.Parse(Console.ReadLine());
//     int number = GetRandom(num1, num2);
//     System.Console.WriteLine($"Рандомное число - {number}");
//     System.Console.WriteLine($"Наибольшая цифра - {FindTheBig(number)}");
// }
// int GetRandom (int num1, int num2)
// {
//     return new Random().Next(num1, num2+1 );
// }
// int FindTheBig (int number)
// {
//     int LastNumb = number % 10;
//     int FirstNumb = number / 10;
//     if (LastNumb > FirstNumb) return LastNumb;
//     return FirstNumb;
// }












// int i = GetRandom();
// System.Console.WriteLine(i);
// System.Console.WriteLine(RemoveSecondDigit(i));

// int GetRandom()
// {
//     return new Random().Next(100, 1000);
// }

// int RemoveSecondDigit(int number)
// {
//     int lastNumber = number % 10;
//     int firstNumber = number / 100;
//     int result = firstNumber*10+lastNumber;
//     return result;
// }








//  Main();

// void Main ()
// {
//     bool Work = true;
//     while (Work)
//     {
//         System.Console.WriteLine("Решаем задачу? Введите y/n.");
//         string a = Console.ReadLine();
//         switch (a) 
//         {
//             case "y":Osn();break;
//             case "n": Work = false; break;
//         }
//     }
// }

// void Osn()
// {
//     System.Console.WriteLine("Введите 1 число");
//     int num1 = int.Parse(Console.ReadLine());
//     System.Console.WriteLine("Введите 2 число");
//     int num2 = int.Parse(Console.ReadLine());
//     int a = Magic(num1, num2);
//     if (a == 0) System.Console.WriteLine($"Число {num1} кратно {num2}.");
//     else System.Console.WriteLine($"Число {num1} не кратно {num2}, остаток {a}.");
// }

// int Magic(int number1, int number2)
// {
//     int a = number1 % number2;
//     return a;
// }









Console.WriteLine("Введите число N");
int a = int.Parse(Console.ReadLine());


bool ISfor7and23 (int number)
{
    return number%7 == 0 && number%23 == 0;
}



if (ISfor7and23(a))
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}
