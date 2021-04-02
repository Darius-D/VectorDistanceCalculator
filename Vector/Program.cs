using System;
using System.Collections.Generic;


namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vector> vectorList = new List<Vector>()
            {
                new Vector(),
                new Vector(),
                new Vector(),
                new Vector()
                
            };

            var result = Calculations.GetClosestVectors(vectorList);
            Console.WriteLine($" The closest points are element {result.ElementLocOne} -- {result.vOne.xValue},{result.vOne.yValue}," +
                              $"{result.vOne.zValue} and element {result.ElementLocTwo} -- {result.vTwo.xValue}, {result.vTwo.yValue}," +
                              $"{result.vTwo.zValue} having a distance of {result.DistanceTo}");

        }
    }

    

    
}
