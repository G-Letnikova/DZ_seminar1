// вводим два числа, выводим какое большее

Console.WriteLine("введите число 1: ");
int N1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число 2: ");
int N2 = Convert.ToInt32(Console.ReadLine());

if (N1 > N2) 
{
    Console.Write($"max = {N1}, ");
    Console.WriteLine($"min = {N2}");
}

else 
{
    Console.Write($"max = {N2}, ");
    Console.WriteLine($"min = {N1}");
}