Point point1 = new Point(2, 3);
Point point2 = new Point(-4, 0);

Console.WriteLine($"({point1.X},{point1.Y})");
Console.WriteLine($"({point2.X},{point2.Y})");


class Point
{
    // Feilds
    private float _x; 
    private float _y;

    //Constrctors
    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }
    public Point()
    {
        X = 0;
        Y = 0;
    }
    //Properties
    public float X
    {
        get => _x;
        set => _x = value;

     }
    public float Y
    {
        get => _y;
        set => _y = value;

     }

}