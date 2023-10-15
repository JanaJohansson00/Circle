using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Triangle // Klassen som innehåller en kunstruktor och en metod.
    {
         int _baseLenght;
         int _height;
         int _side;

        public Triangle(int baseLenght, int height, int side) // Konstruktor med två parametrar
        {
            _baseLenght = baseLenght;
            _height = height;
            _side = side;
        }

        public int getPerimeter()// Metod som returnerar triangels omkrets.
        {
            return _baseLenght + _height + _side;
        }

        public int getArea() // Metod som returnerar triangels area.
        {
            return _baseLenght * _height / 2;
        }
    }
}
