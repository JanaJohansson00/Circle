using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Circle //Klassen som innehåller en konstruktor och en metod.
    {
         float _pi;
         int _radius;

        public Circle(float pi , int radius) //Konstruktor med två parametrar
        {
            _pi = pi;
            _radius = radius;
        }

        public float getArea() // Metod som returnerar cirklens area.
        {
            return _radius * _radius * _pi;
        }

        public float GetPerimeter() // Metod som returnerar cirkelns omkrets.
        {
            return 2 * _pi * _radius;
        }

        public double GetVolume() // Metod som returnerar cirkelns volym.
        {
            return (4 * _pi * _radius * _radius * _radius / 3);
            
        }
    }

}
