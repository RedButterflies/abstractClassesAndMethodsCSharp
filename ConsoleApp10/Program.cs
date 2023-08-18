//abstract classes and methods
 
abstract class Plant
{
    public abstract void planting();
    public abstract void watering();
    public void selling ()
    {
        Console.WriteLine("Enter the price of the first flower: ");
        double price1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the price of the second flower: ");
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
    public void introduction()
    {
        Console.WriteLine("I am a "+colour+ " rose, weigthing "+ weigth + " grams");
    }

}

class Daisy : Plant
{
    public int numberOfLeaves;
    public string colour;

    public Daisy(int numberOfLeaves, string colour)
    {
        this.numberOfLeaves = numberOfLeaves;
        this.colour = colour;
    }

    public override void planting()
    {
        Console.WriteLine("Daisies are very easy to plant, you should do that often ");
    }
    public override void watering() {
        Console.WriteLine("How many liters of water did you water the daisies with in the morning? ");
        double morning = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("How many liters of water did you water the daisies with during the night? ");
        double night = Convert.ToDouble(Console.ReadLine());
        double total = morning + night;
        Console.WriteLine("In the last 24h, you've watered the daisies with "+ total + "l of water. Daisies should consume up to 5l of water a day. Keep that in mind");
    
    }
    public void introduction()
    {
        Console.WriteLine("I am a "+colour+ " daisy with "+numberOfLeaves + " leaves" );
    }
}

class Program
{
    public static void Main(string[] args)
    {

        Rose rose = new Rose("pink", 55.5d);
        rose.watering();
        rose.planting();
        rose.selling();
        rose.introduction();

        Daisy daisy = new Daisy(101,"yellow");
        daisy.watering();
        daisy.planting();
        daisy.selling();
        daisy.introduction();
    }
}


