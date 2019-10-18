using System;
namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);

            //create a point in square (4,2)
            Point point = new Point(4,2);
            bool isOnMap = map.OnMap(point);
            Console.WriteLine(isOnMap);


            //test with a point we know is off map, change value of point to this point
            point = new Point(8,5);
            isOnMap = map.OnMap(point);
            Console.WriteLine(isOnMap);

            //Get the distance between the point 4,2 and 5,5
            point = new Point (4,2);
            Console.WriteLine(point.DistanceTo(5,5));
        }
    }
}