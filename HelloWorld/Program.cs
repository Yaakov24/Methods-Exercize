using System.Xml.Linq;

namespace VariablesExercise
{
    public class A
    {

        Console.WriteLine("what is your name:");
            string name = Console.ReadLine();
    }
    public class B
    {

        Console.WriteLine("what is a good price for a gas station snack:");
            int number = Console.ReadLine();
    }
    public class C
    {

        char letter = 'a';
        bool correct = true;
       
    }
    public class D
    {
        Console.WriteLine("an exhorbent price for an ice cream cone: ");
            double aLot = Console.ReadLine();
        decimal aTon = 7m;
    }
    public class E {
        A a = name;
        B b = number;
        C c = (letter, correct);
        D d = (d)

        Console.WriteLine($"{  (A a = name)} went to the store to get soda pop { ( C c = letter)}\n" +
                $"for {(B b = number)} dollars, { (C c = correct)} to not spend { ( C c = aLot)} on an Ice Cream \n" +
                $" or {(E e = aTon)}thousand on a Bike");
        }
    }
};



public class A
{
}
public class B
{
}
public class C
{
}


public class Common
{
    private static A aInstance = new A();
    private static B bInstance = new B();
    private static C cInstance = new C();

    public static A AInstance
    {
        get { return Common.aInstance; }
        set { Common.aInstance = value; }
    }

    public static B BInstance
    {
        get { return Common.bInstance; }
        set { Common.bInstance = value; }
    }

    public static C CInstance
    {
        get { return Common.cInstance; }
        set { Common.cInstance = value; }
    }
}

public class _A
{
    A a = Common.AInstance;
    B b = Common.BInstance;
    C c = Common.CInstance;






