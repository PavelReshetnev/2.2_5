namespace ConsoleApp5;

public class Person
{

    private int num1;
    private int num2;

    public int Num1
    {
        get => this.num1;
        set => this.num1 = value;
    }

    public int Num2
    {
        get => this.num2; 
        set => this.num2 = value;
    }

    public Person(int num1, int num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }
    public Person()
    {
        Num1 = 222;
        Num2 = 333;
    }



    ~Person()
    {
        Console.WriteLine($"{Num1} has been deleted");
        Console.WriteLine($"{Num2} has been deleted");
    }
}

