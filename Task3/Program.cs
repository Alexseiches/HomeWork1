Console.WriteLine("Введите число : ");
int A = int.Parse(Console.ReadLine());

if (A % 2 ==0)
{
 
    Console.WriteLine($"{A} четное число");
}
else
{
    Console.WriteLine($"{A} нечетное число");
}