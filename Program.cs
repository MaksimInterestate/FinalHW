//Написать программу, которая из имеющенгося массива строк формирует массив строк,
//Длинна которого меньше либо равна 3.


System.Console.Write("Введите длину массива");
int len = Convert.ToInt32(Console.ReadLine());
string[] array = new string[len];
GetArray(array);
PrintArray(array);
System.Console.WriteLine("Отсортированный массив ");
PrintArray2(array);


void PrintArray2 (string[] array) //Вывод массива на экран после прохождения ветволения IF
{   
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3 ) Console.Write(array[i] + ", ");       
    }
    Console.Write(" ]");
    Console.WriteLine();
}

string [] GetArray(string[] result) //Заполнение массива вручную
{
    for (int i = 0; i < result.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива {i+1} : ");
        string a = Console.ReadLine();
        result[i] = a;
    }
    return result;
}
void PrintArray(string[] array) //Вывод массива на экран
{   
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(" ]");
    Console.WriteLine();
}

