using System;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage m_espresso = new Espresso();
            Beverage m_cafeMocha = new Milk(new Mocha(m_espresso));

            Console.WriteLine("가격 : " + m_cafeMocha.Cost());
            Console.WriteLine("성분 : " + m_cafeMocha.GetDescription());
        }
    }
}

public abstract class Beverage
{
    protected string m_description = string.Empty;

    public virtual string GetDescription()
    {
        return m_description;
    }

    public abstract double Cost();
}


public abstract class Decorator : Beverage
{
    public abstract override string GetDescription();
}


public class Espresso : Beverage
{
    public Espresso()
    {
        m_description = "Espresso";
    }

    public override double Cost()
    {
        return 1.2f;
    }
}


public class Milk : Beverage
{
    private Beverage m_beverage;

    public Milk(Beverage a_beverage)
    {
        this.m_beverage = a_beverage;
    }

    public override double Cost()
    {
        return m_beverage.Cost() + .3f;
    }

    public override string GetDescription()
    {
        return m_beverage.GetDescription() + " + Milk";
    }
}


public class Mocha : Decorator
{
    private Beverage m_beverage;

    public Mocha(Beverage a_beverage)
    {
        this.m_beverage = a_beverage;
    }

    public override double Cost()
    {
        return m_beverage.Cost() + .2f;
    }

    public override string GetDescription()
    {
        return m_beverage.GetDescription() + " + 모카";
    }
}


