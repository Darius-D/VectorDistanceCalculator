using System;


namespace Vector
{
    public class Vector
    {
        Random rnd = new Random();
        
        public int xValue { get; }
        public int yValue { get; }
        public int zValue { get; }

        public Vector()
        {
            xValue = rnd.Next(0, 1001);
            yValue = rnd.Next(0, 1001);
            zValue = rnd.Next(0, 1001);
        }
    }
}