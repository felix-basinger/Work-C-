// int Read(string coordinate)
// {
//     System.Console.WriteLine($"Введите {coordinate}:");
//     int x = int.Parse(Console.ReadLine());
//     return x;
// }

// int x = Read("x");
// int y = Read("y");

// int QouteNumb( int x, int y)
// {
//     if (x>0 && y>0) return 1;
//     else if (x>0 && y<0) return 4;
//     else if (x<0 && y>0) return 2;
//     else return 3;
// }

// if (x==0 || y == 0) System.Console.WriteLine("Точка лежит на осях координат и не принадлежит четверти");
// else System.Console.WriteLine($"Точка с координатами {x} {y} лежит в четверти - {QouteNumb(x,y)}");










// int Read(string argument)
// {
//     int number;
//     System.Console.WriteLine($"inpup {argument}: ");
//     while((!int.TryParse(Console.ReadLine(), out number)) || number < 1 || number >4)
//     {
//         System.Console.WriteLine("this isn't a quter");
//     }
//     return number;
// }

// void Quter()
// {
//     int QuterNum = Read("N");
//     if (QuterNum == 1) System.Console.WriteLine("x [0;n] and y [0;n]");
//     else if (QuterNum == 2) System.Console.WriteLine("x [0;-n] and y [0;n]");
//     else if (QuterNum == 3) System.Console.WriteLine("x [0;-n] and y [0;-n]");
//     else  System.Console.WriteLine("x [0;n] and y [0;-n]");
// }

// Quter();


 





 


 /*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/



int Read(string coordinate)
{
    System.Console.Write($"Введите {coordinate}: ");
    int x = int.Parse(Console.ReadLine());
    return x;
}

int xA = Read("x");
int yA = Read("y");
int xB = Read("x");
int yB = Read("y");

double LineSegment (double xA, double yA, double xB, double yB)
{
      double result = Math.Round(Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2)), 2);
      return result;
}

System.Console.WriteLine($"Длина отрезка равна = {LineSegment(xA, yA, xB, yB)}");
