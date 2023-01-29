// Факториал и рекурсия

double Factirial (int n) // из-за переполнения уже на 17!
{
    if (n == 1 || n == 0) return 1;
    else return n * Factirial (n - 1);
}


for (int i = 0; i < 30; i++)
{
    Console.WriteLine($"{i}! = {Factirial (i)}");
}
