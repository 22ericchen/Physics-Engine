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

}
