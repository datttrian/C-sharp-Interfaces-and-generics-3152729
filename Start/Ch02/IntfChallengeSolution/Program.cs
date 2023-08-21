namespace IntfChallengeSolution;

class Program
{
    static void Main(string[] args)
    {
        MyRandomizer mr = new MyRandomizer();

        string str;
        do
        {
            Console.WriteLine("Enter a number for the upper bound: ");
            str = Console.ReadLine();
            try
            {
                double upperBound = Double.Parse(str);
                Console.WriteLine("Random number between 0 and {1}: {0}",
                    mr.GetRandomNum(upperBound), upperBound);
            }
            catch (Exception e) { }
        }
        while (str != "exit");
    }
}
