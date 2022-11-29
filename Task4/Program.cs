// вводим три числа, выводим максимальное

Console.WriteLine("введите число 1: ");
int N1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число 2: ");
int N2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число 3: ");
int N3 = Convert.ToInt32(Console.ReadLine());

if (N1 > N2 && N1 > N3) 
{
    Console.WriteLine($"max = {N1}");
}

    else if (N2 > N3)
        {
          Console.WriteLine($"max = {N2}");
        }
 else 
    {
        Console.WriteLine($"max = {N3}");

     }
            