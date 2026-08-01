using System;

class Pair<A, B>
{
    A a;
    B b;

    public Pair(A a, B b)
    {
        this.a = a;
        this.b = b;
    }

    public string ToString()
    {
        return $"({a}, {b})";
    }
}

class Program
{
    static void Main()
    {
        var p = new Pair<string, int>("Ada", 36);
        Console.WriteLine(p.ToString());
    }
}
