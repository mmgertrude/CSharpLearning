namespace TreehouseDefense
{
    class Map
    {
        public readonly int Width;
        public readonly int Height;
        
        public Map(int width, int height) //constructor used to create objects of the Map class
        {
            Width = width;
            Height = height;
        }

        //Within the class Map, create a method that checks if an object exists on the map
        public bool OnMap (Point point) // the point parameter is of object type Point
        //here we created a variable of a type we created ourselves -- type Point!!
        // the return type of this method is boolean
        //the method is public so it can be accessed outside the Map class
        {
            //the map image shows that all X values must be >=0 and < 8 and 
            // all Y values must be >=m 0 and < 5
            //lets define a variable inBounds to hold the bolean value indicating if a point is 
            // inbound or not:
            bool inBounds = ((  point.X >=0 && point.X < Width) &&
                                point.Y>=0 && point.Y < Height);
            return inBounds;
        }
    }
}