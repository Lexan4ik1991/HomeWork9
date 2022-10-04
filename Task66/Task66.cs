/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintSumNumber(m, n));

int PrintSumNumber(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    return(start + PrintSumNumber(start + 1, end));
}
 