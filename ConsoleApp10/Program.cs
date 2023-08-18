//abstract classes and methods
 
abstract class Plant
{
    public abstract void planting();
    public abstract void watering();
    public void selling ()
    {
        double price1 = Convert.ToDouble(Console.ReadLine());
        double price2 = Convert.ToDouble(Console.ReadLine());
        double total = price1 + price2;
        Console.WriteLine("The total equals to: "+total);
    }
}

class Rose : Plant
{
    public string colour;
    public double weigth;

    public Rose(string colour, double weigth)
    {
        this.colour = colour;
        this.weigth = weigth;
    }

    public override void planting()

    {
        Console.WriteLine("How many roses have you planted today? ");
        int roses = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Today, you've planted "+ roses + " roses");

    }
    public override void watering()
    {
        Console.WriteLine("Watering is very important for plants, your roses will grow healthy if you water them well");
    }

}

