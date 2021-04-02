using System;
using System.Collections.Generic;


namespace Vector
{
    public class Calculations
    {
        private static Result GetVectorDistance(Vector vectorOne, Vector vectorTwo)
        {

            Result result = new Result();

            result.vOne = vectorOne;
            result.vTwo = vectorTwo;

            var xVal = vectorTwo.xValue - vectorOne.xValue;
            var yVal = vectorTwo.yValue - vectorOne.yValue;
            var zVal = vectorTwo.zValue - vectorOne.zValue;

            var distance = Math.Sqrt((Math.Pow(xVal, 2) + Math.Pow(yVal, 2) + Math.Pow(zVal, 2)));

            result.DistanceTo = distance;

            return result;
        }
        

        public static Result GetClosestVectors(List<Vector> vectors)
        {
           Result closestDistance = new Result()
           {
               vOne = null,
               vTwo = null,
               ElementLocOne = 0,
               ElementLocTwo = 0,
               DistanceTo = (double)int.MaxValue
           };

            for (int i = 0; i < vectors.Count -1; i++)
            {
                for (int j = i + 1; j < vectors.Count; j++)
                {
                    var result = GetVectorDistance(vectors[i], vectors[j]);

                    if (result.DistanceTo < closestDistance.DistanceTo)
                    {
                        closestDistance.ElementLocOne = i;
                        closestDistance.ElementLocTwo = j;
                        closestDistance.DistanceTo = result.DistanceTo;
                        closestDistance.vOne = result.vOne;
                        closestDistance.vTwo = result.vTwo;
                    }
                }
            }

            return closestDistance;
        }
        

    }
}
