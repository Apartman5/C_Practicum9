// Задача 65: 
// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите n");
int n = Convert.ToInt32(Console.ReadLine());
if (m > n)
    {
        int temp = m;
        m = n;
        n = temp;
    }

string NaturalNumbers (int m, int n)
{
    string end = " ";
    Console.Write(m + " ");
    if (m < n)
        return NaturalNumbers(m + 1, n);
    else return end ;
}

NaturalNumbers(m, n);
