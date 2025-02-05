namespace Supplementpt1_2;

public class Supplementpt1_2
{
    /// <summary>
    /// provides methods for generating random numbers, passwords, and colors
    /// </summary>
    public static readonly Random random = new Random();

    /// <summary>
    /// generates a random number
    /// </summary>
    /// <param name="mean"></param>
    /// <param name="standardDev"></param>
    /// <returns></returns>
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
        Random rand = new Random();
        int r = rand.Next(256);
        int g = rand.Next(256);
        int b = rand.Next(256);
        string hex = $"#{r:X2}{g:X2}{b:X2}";
        return (hex, (r, g, b));
        } 
}
