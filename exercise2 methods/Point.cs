using System;
namespace TreehouseDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;
        
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        //method to determine distance between 2 points (the x and y in the method and the X and Y of the class)
        //Also include using System; at the top in order to use Math.Sqrt()
        public int DistanceTo(int x, int y)
        {
            int xDiffSquared = (X-x)*(X-x);
            int yDiffSquared = (Y-y)*(Y-y);
            //recall that Math.Sqrt returns a bouble. type cast the results with int since the return value
            //of DistanceTo() is supposed to be int
           return (int)Math.Sqrt(xDiffSquared + yDiffSquared);
           //alternative code
           //return (int)Math.Sqrt(Math.Pow(X-x,2)+Math.Pow(Y-y));           

        }

        //here lets overload the DistanceTo method
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y); //call to the first DistanceTo method
        }



    }
}