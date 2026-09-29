namespace Infrastructure;

public class Person
{
    public int Age {get; set;}
    public string ? Name {get; set;}
    public virtual void Greet()
    {
        System.Console.WriteLine($"Hello i am {Name}");

    }
    public virtual void SetAge(int age)
    {
        Age = age;
        System.Console.WriteLine($"i am {age}");
    }


}
