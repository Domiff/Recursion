void PrintNumbers(int m, int n)
{
    if (m > n)
    {
        Console.WriteLine(m);
        PrintNumbers(m - 1, n);
    }
    else if( m == n)
    {
        Console.WriteLine(n);
    }
    if (n > m)
    {
       PrintNumbers(m, n - 1);
       Console.WriteLine(n);
    }
}

PrintNumbers(4, 8);