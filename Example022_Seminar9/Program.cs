// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

// Console.WriteLine($"result = {InputNumbers()}");


// int InputNumbers()
// {
// 	bool isWork = true;
// 	int count = 0;

// 	while (isWork)
// 	{
// 		Console.WriteLine("Input number");
// 		string command = Console.ReadLine();

// 		if (int.TryParse(command, out int number))
// 		{
// 			count++;
// 		}

// 		if (command == "exit")
// 		{
// 			isWork = false;
// 		}
// 	}

// 	return count;
// }














// int GetN ()
// {
//     System.Console.WriteLine("Введите N ");
//     return int.Parse(Console.ReadLine());
// }

// int N = GetN();
// System.Console.WriteLine();
// void Numbers(int N)
// {
//     if(N >0 ) 
//     {
//         Numbers(N-1);
//         System.Console.WriteLine(N);
//     }
// }

// Numbers(N);










// void PrintNum(int m, int n)
// {
    
// if (n>=m)
// {
//     Console.Write(m);
//     PrintNum(m+1, n);
// }
// }
// PrintNum(5, 10);












int GetN ()
{
    System.Console.WriteLine("Введите N ");
    return int.Parse(Console.ReadLine());
}

//int N = GetN();

int Summ(int N)
{
    int sum = N%10;

    if (N >1)
    return Summ(N/10)+sum;
    return sum;
}

System.Console.WriteLine(Summ(GetN()));
