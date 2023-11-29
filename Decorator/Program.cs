

#region Decarator_Befo

//interface ICoffee
//{
//    string GetDescription();
//    double Cost();
//}
//
//
//class SimpleCoffee : ICoffee
//{
//    public string GetDescription()
//    {
//        return "Simple Coffee";
//    }
//    public double Cost()
//    {
//        return 2.0;
//    }
//}
//
//
//
//class MilkDecorator : ICoffee
//{
//
//
//    public MilkDecorator()
//    {
//
//    }
//
//    public string GetDescription()
//    {
//        return $"Simple Coffe, Milk";
//
//    }
//
//    public double Cost()
//    {
//        return 2.0 + 0.5;
//    }
//}
//
//class SugarDecorator : ICoffee
//{
//
//    public SugarDecorator()
//    {
//
//    }
//
//    public string GetDescription()
//    {
//        return $"Simple Coffe, Sugar";
//
//    }
//
//    public double Cost()
//    {
//        return 2.0 + 0.2;
//    }
//}
//
//
//

#endregion

#region Decarator_After
interface ICoffee
{
    // Base interface yaradiriq ICoffee adinda 
    // GetDescription() Hansi novde oldugunu qaytaran funksiyamiz var
    // Cost() Qiymetini qaytaran funksiyamiz var
    string GetDescription();
    double Cost();
}

class SimpleCoffee : ICoffee
{
    // Sade cofe hazirlayir
    public string GetDescription()
    {
        return "Simple Coffee";
    }
    public double Cost()
    {
        return 2.0;
    }
}

abstract class CoffeeDecorator : ICoffee
{
    //Base abstract CoffeeDecorator
    protected ICoffee coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        this.coffee = coffee;
    }

    public virtual string GetDescription()
    {
        return coffee.GetDescription();
    }

    public virtual double Cost()
    {
        return coffee.Cost();
    }
}

class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()}, Milk";

    }

    public override double Cost()
    {
        return base.Cost() + 0.5;
    }
}

class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()}, Sugar";

    }

    public override double Cost()
    {
        return base.Cost() + 0.2;
    }
}

//class ChocolateDecorator : CoffeeDecorator
//{
//    public ChocolateDecorator(ICoffee coffee) : base(coffee)
//    {
//    }
//
//    public override string GetDescription()
//    {
//        return $"{base.GetDescription()}, Chocolate";
//    }
//
//    public override double Cost()
//    {
//        return base.Cost() + 0.2;
//    }
//}


#endregion

class Program
{
    static void Main()
    {

        
        //Befo Version

        //ICoffee MilkCoffee = new MilkDecorator();
        //ICoffee sugarCoffee = new SugarDecorator();
        //ICoffee SimpleCoffee = new SimpleCoffee();
        //Console.WriteLine(MilkCoffee.GetDescription() + "\n" + MilkCoffee.Cost()
        //    + "\n\n" + sugarCoffee.GetDescription() + "\n" + sugarCoffee.Cost()
        //    + "\n\n" + SimpleCoffee.GetDescription() + "\n" + SimpleCoffee.Cost());


        //After Version

        ICoffee sugarAndMilkCoffee = new SugarDecorator(new MilkDecorator(new SimpleCoffee()));
        Console.WriteLine("GetDescription : "+sugarAndMilkCoffee.GetDescription()
            + "\nCost           : "+ sugarAndMilkCoffee.Cost());
    }
}

