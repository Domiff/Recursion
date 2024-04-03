// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ack(int n, int m)
{
    if (n == 0)
    {
        return ++m;
    }
    else if (m == 0 && n > 0)
    {
        return Ack(n - 1, 1);
    }
    else
    {
        return Ack(n - 1, Ack(n, m - 1));
    }
    
}

int result = Ack(3, 3);
Console.WriteLine(result);