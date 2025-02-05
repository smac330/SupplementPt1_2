namespace Supplementpt1_2;

public class Supplementpt1_2
{
    public static readonly Random random = new Random();

   public static double GenerateRandom(double mean, double standardDev)
    {
        double num1 = 1.0 - random.NextDouble();
        double num2 = 1.0 - random.NextDouble();
        double randStandardNormal = Math.Sqrt(-2.0 * Math.Log(num1)) * Math.Sin(2.0 * Math.PI * num2);
        return mean + standardDev * randStandardNormal;
    } 

    public static double GeneratePassword(int length)
        {
            throw new NotImplementedException();
        } 

    public static (string, (int, int, int)) GenerateColor()
        {
            throw new NotImplementedException();
        } 
}
