/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world",":-)"]-> ["2",":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"] 
["Russia", "Denmark", "Kazan"] -> []
*/
string [] InitArray()
{
     int l = 0;
    while(true)
    {
        Console.WriteLine("Введите размер массива:");
        if(int.TryParse(Console.ReadLine(), out l))
        {
            if (l>0)  break;
            else
            {
            Console.WriteLine("Число не может быть размером массива. Повторите ввод");
            }
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    
    string [] result = new string [l];
      

    for (int i = 0; i < result.Length; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива:");
        result[i]=Console.ReadLine(); 
    }

    return result;
}

void PrintArray(string [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
    Console.Write($"'{arr[i]}', ");
    }
    Console.Write($"'{arr[arr.Length-1]}']");
    Console.WriteLine();
}


string [] ChooseArray(string [] arr)
{
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <=3) count++;

    }

    if (count==0) count=1;
     
    string [] result = new string [count];
    int j= 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <=3) 
        {
        result [j]=arr [i]; 
        j++;
        };

    }
return result;
}

string [] arr= InitArray ();
PrintArray (arr);
PrintArray (ChooseArray (arr));
