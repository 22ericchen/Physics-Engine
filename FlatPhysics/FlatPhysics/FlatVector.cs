using System;
namespace FlatPhysics;

public class FlatVector
{
    public readonly float X;
    public readonly float Y;
    
    public FlatVector (float x, float y) 
    {
        this.X = x;
        this.Y = y;
    }   

    public static FlatVector operator + (FlatVector a, FlatVector b) 
    {
        return new FlatVector(a.X + b.X, a.Y + b.Y);    
    }

    public static FlatVector operator - (FlatVector a, FlatVector b)
    {
        return new FlatVector(a.X - b.X, a.Y - b.Y);    
    }

    public static FlatVector operator - (FlatVector a)
    {
        return new FlatVector(-a.X, -a.Y);
    }

    public static FlatVector operator * (FlatVector a, float s)
    {
        return new FlatVector(a.X * s, a.Y * s);
    }
    
    internal static FlatVector Transform(FlatVector v, FlatTransform transform)
    {
        return new FlatVector(
            transform.Cos * v.X - transform.Sin * v.Y + transform.PositionX, 
            transform.Sin * v.X + transform.Cos * v.Y + transform.PositionY);
    }

    public bool Equals(FlatVector other)
    {
        return this.X == other.X && this.Y == other.Y;
    }

    public override bool Equals(object? obj)
    {
       if (obj is FlatVector other)
            {
                return this.Equals(other);
            }

            return false;
    }

}
