﻿namespace Supplementpt1_2;

public class Supplementpt1_2
{
    /// <summary>
    /// provides methods for generating random numbers, passwords, and colors
    /// </summary>
    public static readonly Random random = new Random();

    /// <summary>
    /// generates a random number
    /// </summary>
    /// <param name="mean">the mean value.</param>
    /// <param name="standardDev">the standard deviation</param>
    /// <returns>a random number</returns>
   public static double GenerateRandom(double mean, double standardDev){
        double num1 = 1.0 - random.NextDouble();
        double num2 = 1.0 - random.NextDouble();
        double randStandardNormal = Math.Sqrt(-2.0 * Math.Log(num1)) * Math.Sin(2.0 * Math.PI * num2);
        return mean + standardDev * randStandardNormal;
    } 

    /// <summary>
    /// generates a random password consisting of uppercase & lowercase letters, numbers, and underscores.
    /// </summary>
    /// <param name="length">the length of the password</param>
    /// <returns>randomly generated password string</returns>
    public static string GeneratePassword(int length){
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_";
        Random rand = new Random();

        return new string(Enumerable.Range(0, length).Select(_ => chars[rand.Next(chars.Length)]).ToArray());
    } 

    /// <summary>
    /// generates a random color as a hex string and its RGB values.
    /// </summary>
    /// <returns> a tuple with the above values</returns>
    public static (string, (int, int, int)) GenerateColor(){
        Random rand = new Random();
        int r = rand.Next(256);
        int g = rand.Next(256);
        int b = rand.Next(256);
        string hex = $"#{r:X2}{g:X2}{b:X2}";
        return (hex, (r, g, b));
    } 
}
