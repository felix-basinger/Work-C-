﻿int a = new Random().Next(1, 11);
Console.WriteLine(a);
int b = new Random().Next(1, 11);
Console.WriteLine(b);
int c = new Random().Next(1, 11);
Console.WriteLine(c);
int d = new Random().Next(1, 11);
Console.WriteLine(d);
int e = new Random().Next(1, 11);
Console.WriteLine(e);

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;

Console.WriteLine("Максимальное число: " + max);