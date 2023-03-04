namespace ConsoleApp5;

public class Program
{
    public static void Method()
    {
        Person tom = new Person();
    }
    static void Main(string[] args)
    {
        Method();

        GC.Collect();
        Console.ReadLine();
    }
}