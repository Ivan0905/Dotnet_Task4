//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{a} в степение {b} равно {row(a,b)}");

int row(int x, int y)
{
    int n = x;
    for (int i = 1; i < y; i++)
    {
        n = n * x;
    }
    return n;
}
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.WriteLine("Введите число");
string str = Console.ReadLine()!;
Console.WriteLine($"Сумма цифр числа {str} равна {Len(str)}");

int Len(string len)
{
    int sum = 0;
    int n = len.Length;
    string x;
    for (int i = 0; i < n; i++)
    {
        x = Convert.ToString(len[i]);
        sum = sum + int.Parse(x);
        Console.WriteLine();
        Console.WriteLine(Convert.ToInt16(x));
    }
    return sum;
}


