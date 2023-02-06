// Собрать строку с числами от а до b, а<= b

string NumbersFor (int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec (int a, int b)
{
    if (a <= b) return  $"{a} " + NumbersRec (a + 1, b);
    else return String.Empty;
}


Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));


Console.WriteLine();




// Собрать строку с числами от b до a, а<= b

string NumbersForBA (int a, int b)
{
    string result = String.Empty;
    for (int i = b; i >= a; i--)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRecBA (int a, int b)
{
    if (a <= b) return   NumbersRecBA (a + 1, b) + $"{a} ";
    else return String.Empty;
}


Console.WriteLine(NumbersForBA(1, 10));
Console.WriteLine(NumbersRecBA(1, 10));
