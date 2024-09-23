namespace Topic_5___Assigment_Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight, planetWeight;
            int planet;
            planetWeight = 0;
            Boolean valid = true;
            Console.WriteLine("Please enter your current Earth weight (lbs):");
            double.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine("I have information on the following planets:");
            Console.WriteLine(" 1. Venus  2. Mars   3. Jupiter");
            Console.WriteLine(" 4. Saturn 5. Uranus 6. Neptune");
            Console.WriteLine("Please enter the number of the planet you would like to visit");
            Console.WriteLine();
            Int32.TryParse(Console.ReadLine(), out planet);
            
            
            if (planet == 1)
                planetWeight = weight * 0.78;
            else if (planet == 2)
                planetWeight = weight * 0.39;
            else if (planet == 3)
                planetWeight = weight * 2.65;
            else if (planet == 4)
                planetWeight = weight * 1.17;
            else if (planet == 5)
                planetWeight = weight * 1.05;
            else if (planet == 6)
                planetWeight = weight * 1.23;
            else
            {
                valid = false;
                Console.WriteLine();
                Console.WriteLine("Invalid Input");
            }




            if (valid == true)
            {
                Console.WriteLine();
                Console.WriteLine("Your weight on that planet would be " + planetWeight + " lbs!");
            }
        }
    }
}
