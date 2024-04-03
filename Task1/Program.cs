int PrintNumbers(int m, int n)
{
    int result = 0;

    if (m == n)
    {
        Console.WriteLine(result + m);
        return n;
    }
    if (m > n)
    {
        Console.WriteLine(m - result);
        return m;
    }
    Console.WriteLine(result + m);
    m++;
    
    PrintNumbers(m, n);
    return result;
}


PrintNumbers(2, 4);