 /*int i = 0;

 if(int.TryParse(Console.ReadLine(), out i))
 {
    Console.WriteLine(i * i);
 }
 else
 {
    Console.WriteLine("OOps");
 }*/

// Задача 1

/*int i = 0;

if (int.TryParse(Console.ReadLine(), out i))
{
    Console.WriteLine(i * i);
}
else
{Console.Write("Ops");}*/

// Задача 2

/*int a;
int b;
Console.WriteLine("Введите число 'a'");
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine("Введите число 'b'");
int.TryParse(Console.ReadLine(), out b);

if (b * b == a)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}*/

// Задача 3

int i;
Console.WriteLine("Введите цифру от 1 до 7");
int.TryParse(Console.ReadLine(), out i);

if (i == 1)
{
     Console.WriteLine("Понедельник");
}
else if (i == 2)
{
     Console.WriteLine("Вторник");
}
else if (i == 3)
{
    Console.WriteLine("Среда");
}
else if (i == 4)
{
    Console.WriteLine("Четверг");
}
else if (i == 5)
{
    Console.WriteLine("Пятница");
}
else if (i == 6)
{
    Console.WriteLine("Суббота");
}
else if (i == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Неверно указаны данные. Введите цифру от 1 до 7");
}
