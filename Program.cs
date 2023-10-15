namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello! In this program I have calculated the perimeter, area and the volume of two circles." +
                "\nI have also calcuated the perimeter and area of a triangle");
            Console.WriteLine("======================================================================"); 

            // Skapat ett objekt av Cirkle klassen.
            Circle firstCircle = new Circle(3.141f, 5);
            Circle secondCircle = new Circle(3.141f, 6);

            Console.WriteLine("Circle nr 1: ");

            //Beräknar omkretsen med GetPerimeter metoden
            float perimeter1 = firstCircle.GetPerimeter();
            Console.WriteLine("Perimeter: " + perimeter1 + " cm");

            // Beräknar arean med getArea metoden.
            float area1 = firstCircle.getArea();
            Console.WriteLine("Area: " + area1 + " cm");

            //Beräknar volymen med GetVolume metoden
            double volume1 = firstCircle.GetVolume();
            Console.WriteLine("Volume: " + volume1 + " cm^3");
            Console.WriteLine();

            Console.WriteLine("Circle nr 2: ");

            //Beräknar omkretsen med GetPerimeter metoden
            float perimeter2 = secondCircle.GetPerimeter();
            Console.WriteLine("Perimeter: " + perimeter2 + " cm");
            float area2 = secondCircle.getArea();
            Console.WriteLine("Area: " + area2 + " cm");

            //Beräknar volymen med GetVolume metoden
            double volume2 = secondCircle.GetVolume();
            Console.WriteLine("Volume: " + volume2 + " cm^3");
            Console.WriteLine();

            Console.WriteLine("Here is the calculations of the triangle!");
            Console.WriteLine("---------------------------------------------------------------------");

            //Skapat objekt av Triangle klassen
            Triangle trianglePerimeter = new Triangle(18, 6, 8);
            int trianglePerimeterValue = trianglePerimeter.getPerimeter();
            Console.WriteLine("Triangle Perimeter: " + trianglePerimeterValue + " cm");

            Triangle triangleArea = new Triangle(18, 6, 8);
            int triangleAreaValue = triangleArea.getArea();
            Console.WriteLine("Triangle Area: " + triangleAreaValue + " cm");
            

        }
    }
}