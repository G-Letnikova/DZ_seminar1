// вводим число (N), выводим все четные от 1 до N

Console.WriteLine("введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

while (N<=1)
{
    Console.WriteLine($"{N} некорректное число, введите число, больше 1");
    N = Convert.ToInt32(Console.ReadLine());

}

for (int i=2; i <= N; i=i+2) 
   {
     Console.Write($"{i} ");
   }


