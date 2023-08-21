namespace IntfChallengeSolution;

public class MyRandomizer : IRandomizable
{
    public MyRandomizer() { }

    public double GetRandomNum(double dUpperBound)
    {
        Random rnumGen = new Random();
        double seed = rnumGen.NextDouble();
        return seed * dUpperBound;
    }
}
