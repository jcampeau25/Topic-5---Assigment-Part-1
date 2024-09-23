namespace Topic_5___Assigment_Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight, planetWeight;
            int planet;
            Console.WriteLine("Please enter your current Earth weight (lbs):");
            double.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine("I have information on the following planets:");
            Console.WriteLine(" 1. Venus  2. Mars   3. Jupiter");
            Console.WriteLine(" 4. Saturn 5. Uranus 6. Neptune");
            Console.WriteLine("Please enter the number of the planet you would like to visit");
            Int32.TryParse(Console.ReadLine(), out planet);

            if (planet == 1);
                planetWeight = weight * 0.78;
            if (planet == 2);
                planetWeight = weight * 0.39;
            if (planetWeight == 3)





            Console.WriteLine("Your weight on that planet would be " + planetWeight + " lbs");

        }
    }
}
