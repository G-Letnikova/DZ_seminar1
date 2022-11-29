// вводим два числа, выводим какое большее

Console.WriteLine("введите число 1: ");
int N1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число 2: ");
int N2 = Convert.ToInt32(Console.ReadLine());

if (N1 > N2) 
{
    Console.WriteLine($"max = {N1}");
}

else 
{
    Console.WriteLine($"max = {N2}");
}