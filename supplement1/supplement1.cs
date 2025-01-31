namespace supplement1;

public class supplement1
{
    /// <summary>
    /// returns the area of a rectangle. if the length is equal to the width
    /// the calculation is done as length * length
    /// </summary>
    /// <param name="length"> length of the rectangle</param>
    /// <param name="width">  width of the rectangle</param>
    /// <returns>Area of the rectangle</returns>
    
    public static double AreaOfRectangle(double length, double width){
        if (length == width){
            return length * length;
        } else {
            return length * width;
        }
    }

    /// <summary>
    /// returns the area of a circle given the radius 
    /// </summary>
    /// <param name="radius"> radius of a circle</param>
    /// <returns> the area of a circle with a given radius</returns>
    
    public static double AreaOfCircle(double radius){
        return double.Pow(radius, 2.0) * double.Pi;
    }

    public static double AreaOfTriangle(double triangleBase, double triangleHeight){
        return triangleBase * triangleHeight / 2;         
    }
}
