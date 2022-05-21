// See https://aka.ms/new-console-template for more information

using AllowPrincple;
class Program
{

    static void Main(string[] args)
    {
        #region Execute without allow princple
        Console.WriteLine("Execute without allow princple");
        Apple apple = new Orange();
        Console.WriteLine("Color : " + apple.getColor());
        #endregion


        #region Execute with allow princple
        Console.WriteLine("Execute with allow princple");
        Fruit fruit = new AllowPrincple.Orange();
        Console.WriteLine("Orange Color : " + fruit.getColor());
        fruit = new AllowPrincple.Apple();
        Console.WriteLine("Apple Color : " + fruit.getColor());
        #endregion

    }


}

#region Without allow princple
public class Apple
{
    public virtual string getColor()
    {
        return "Red";
    }
}

public class Orange : Apple
{
    public override string getColor()
    {
        return "Orange";
    }
}
#endregion


#region With allow Princple
namespace AllowPrincple
{


    public abstract class Fruit
    {
        public abstract string getColor();
    }

    public class Apple : Fruit
    {
        public override string getColor()
        {
            return "Red";
        }
    }

    public class Orange : Fruit
    {
        public override string getColor()
        {
            return "Orange";
        }
    }

}
#endregion
