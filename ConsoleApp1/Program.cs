interface ICoffee
{ 
    string GetDescription();
    double Cost();
}


class SimpleCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Simple Coffee";
    }
    public double Cost()
    {
        return 2.0;
    }
}



class MilkDecorator: ICoffee
{
   

    public MilkDecorator() 
    {
        
    }

    public string GetDescription()
    {
        return $"Simple Coffe, Milk";

    }

    public double Cost()
    {
        return 2.0 + 0.5;
    }
}

class SugarDecorator : ICoffee
{
    
    public SugarDecorator() 
    {
        
    }

    public string GetDescription()
    {
        return $"Simple Coffe, Sugar";

    }

    public double Cost()
    {
        return 2.0+0.2;
    }
}

class Program
{
    static void Main()
    {

        //Befo Version
        ICoffee MilkCoffee = new MilkDecorator();
        ICoffee sugarCoffee = new SugarDecorator();
        ICoffee SimpleCoffee = new SimpleCoffee();
        Console.WriteLine(MilkCoffee.GetDescription()+"\n"+ MilkCoffee.Cost()
            +"\n\n"+ sugarCoffee.GetDescription() + "\n" + sugarCoffee.Cost()
            +"\n\n"+ SimpleCoffee.GetDescription() + "\n" + SimpleCoffee.Cost());

        
    }
}

