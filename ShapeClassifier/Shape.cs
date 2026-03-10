using System;
using System.Collections.Generic;
using System.Text;



class Shape
{
    
}

class Circle : Shape
{
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Radius { get; set; }
}

class Rectangle : Shape
{
    public Rectangle (double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Width { get; set; }
    public double Height { get; set; }
}

class Square : Shape
{
    public Square(int side)
    {
        Side = side;
    }

    public double Side { get; set; }
}

