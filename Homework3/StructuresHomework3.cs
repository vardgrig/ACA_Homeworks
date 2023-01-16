using System;

struct Coordinate
{
    public int x { get; set; }
    public int y { get; set; }

    public Coordinate(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public float CalculateDistance(Coordinate first, Coordinate second)
    {
        float distance = Sqrt(Math.Pow(Math.Abs(first.x - second.x),2) + Math.Pow(Math.Abs(first.y - second.y), 2));
        return distance;
    }
}