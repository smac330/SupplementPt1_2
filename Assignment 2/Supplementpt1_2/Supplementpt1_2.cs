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

    public static string GeneratePassword(int length){
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_";
        Random rand = new Random();

        return new string(Enumerable.Range(0, length).Select(_ => chars[rand.Next(chars.Length)]).ToArray());
        } 

    public static (string, (int, int, int)) GenerateColor()
        {
            throw new NotImplementedException();
        } 
}
