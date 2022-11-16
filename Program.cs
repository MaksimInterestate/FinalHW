//Написать программу, которая из имеющенгося массива строк формирует массив строк,
//Длинна которого меньше либо равна 3.


System.Console.Write("Введите длину массива");
int len = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите строку");
string [] str = new string[len];
for (int i = 0; i < len; i++)
{
    str[i] = Console.ReadLine();
}
System.Console.WriteLine("Введенный массив строк");
System.Console.Write("[ ");
for (int i = 0; i < len; i++)
{
    System.Console.Write(str[i] + ", ");
}
System.Console.WriteLine(" ]");
System.Console.WriteLine("Отсортированный массив ");
System.Console.Write("[ ");
for (int i = 0; i < len; i++)
{
    if(str[i].Length <=3) System.Console.Write(str[i]+ ", ");
}
System.Console.WriteLine(" ]");

