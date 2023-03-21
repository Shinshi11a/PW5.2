using System;
using System.Collections.Generic;

interface IHello
{
    void SayHello();
}

class EnglishHello : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Hello");
    }
}

class FrenchHello : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Bonjour");
    }
}

class SpanishHello : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Hola");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<IHello> hellos = new List<IHello>();
        hellos.Add(new EnglishHello());
        hellos.Add(new FrenchHello());
        hellos.Add(new SpanishHello());

        foreach (IHello hello in hellos)
        {
            hello.SayHello();
        }
    }
}
