// вводим число, выводим четное оно или нет

Console.WriteLine("введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N%2 == 0) 
{
    Console.WriteLine($"да");
}

else 
{
    Console.WriteLine($"нет");
}