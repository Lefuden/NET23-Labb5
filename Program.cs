//Daniel Frykman .NET23

using Console = System.Console;

namespace Labb5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create objects
            Geometry myCircle = new(5);
            Geometry myCircle2 = new(6);
            Geometry mySphere = new(5.5f);
            Geometry myTriangle = new(5.2f, 3, 4.3f);
            Geometry myCylinder = new(3, 7.6f);
            Geometry myRectangle = new(5.4f, 5);

            //use methods to calculate and output data
            Console.WriteLine("The amazing geometry calculator!\n");
            myCircle.CalculateCircle();
            myCircle2.CalculateCircle();
            mySphere.CalculateSphere();
            myTriangle.CalculateTriangle();
            myCylinder.CalculateCylinder();
            myRectangle.CalculateRectangle();
        }
    }
}