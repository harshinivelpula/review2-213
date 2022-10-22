

using AbstractClass;

class Program
{
    static void Main(string[] args)
    {
        
        SportsBike s1 = new SportsBike();
        s1.brake();

        
        AbstractClass.MountainBike m1 = new MountainBike();
        m1.brake();

        Console.ReadLine();
    }
}