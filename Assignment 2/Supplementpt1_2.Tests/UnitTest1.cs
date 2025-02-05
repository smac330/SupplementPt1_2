
namespace Supplementpt1_2.Tests;

public class UnitTest1
{

    [Fact]
    public void TestGenerateRandom()
    {
       double mean = 50;
        double standardDev = 10;
        int sampleSize = 10000;
        double sum = 0, sumSquares = 0;
        Random rand = new Random();

        for (int i = 0; i < sampleSize; i++)
        {
            double value = Supplementpt1_2.GenerateRandom(mean, standardDev);
            sum += value;
            sumSquares += value * value;
        }

        double calculatedMean = sum / sampleSize;
        double calculatedStdDev = Math.Sqrt(sumSquares / sampleSize - calculatedMean * calculatedMean);

        Assert.InRange(calculatedMean, mean - 1, mean + 1);
        Assert.InRange(calculatedStdDev, standardDev - 1, standardDev + 1);
    }

    [Fact]
    public void TestGeneratePassword()
        {
            int length = 10;
            string password = Supplementpt1_2.GeneratePassword(length);

            Assert.Equal(length, password.Length);
            Assert.Matches("^[A-Za-z0-9_]+$", password);
        }


}
