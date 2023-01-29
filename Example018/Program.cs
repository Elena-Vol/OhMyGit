// Факториал и рекурсия

double Factorial (int n) // из-за переполнения уже на 17!
{
    if (n == 1 || n == 0) return 1;
    else return n * Factorial (n - 1);
}


for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{i}! = {Factorial (i)}");
}
