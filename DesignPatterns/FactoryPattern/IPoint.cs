using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
  public  interface IPoint
    {
    void GetPoint();
    }

    public abstract class PointFactory
    {
        public abstract IPoint createPoint(double x, double y);
    }

    public class PolarFactory : PointFactory
    {

        public override IPoint createPoint(double x, double y) => new Polar(x, y);
       
    }


    public class CartesianFactory : PointFactory
    {

        public override IPoint createPoint(double x, double y) => new Cartesian(x, y);
        
    }


    public class Polar : IPoint
    {
        private double _x, _y;

        public Polar(double a, double b)
        {
            _x = a * Math.Sin(b);
            _y = a * Math.Cos(b);
        }
        public void GetPoint()
        {
            Console.WriteLine($"the point is X:{_x},,,,,Y:{_y}");
        }
    }


    public class Cartesian : IPoint
    {

        private double _x, _y;

        public Cartesian(double a, double b)
        {
            _x = a;
            _y = b;
        }
        public void GetPoint()
        {
            Console.WriteLine($"the point is X:{_x},,,,,Y:{_y}");
        }
    }
}
