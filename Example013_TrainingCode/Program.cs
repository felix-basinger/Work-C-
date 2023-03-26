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

int [] array = new int[10];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

FillArray(array);
PrintArray(array);