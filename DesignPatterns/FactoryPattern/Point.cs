using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public enum CoordinatSytem
    {
        Cartesian,
        Polar
    }


    public class Point
    {
        private readonly Dictionary<CoordinatSytem, PointFactory> pointList;


        public IPoint ExecuteCreation(CoordinatSytem coordinatSytem, double x, double y) => pointList[coordinatSytem].createPoint(x, y);
        public Point()
        {
            //pointList = new Dictionary<CoordinatSytem, PointFactory>()
            //{
            //    { CoordinatSytem.Cartesian,new CartesianFactory()},
            //     { CoordinatSytem.Polar,new PolarFactory()}


            //};

            pointList = new Dictionary<CoordinatSytem, PointFactory>();


            foreach(CoordinatSytem coordinatSytem in Enum.GetValues(typeof(CoordinatSytem)))
                {

                var factory = (PointFactory)Activator.CreateInstance(Type.GetType("FactoryMethod." + Enum.GetName(typeof(CoordinatSytem), coordinatSytem) + "Factory"));
                pointList.Add(coordinatSytem, factory);

            }
        }
    

    }
}