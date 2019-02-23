
using System;


class Tank
{

    double t_radius;
    double t_height;

    // Properties for Radius and Height 
    public double Radius
    {
        get
        {
            return t_radius;
        }

        set
        {
            t_radius = value < 0 ? -value : value;
        }
    }

    public double Height
    {
        get
        {
            return t_height;
        }

        set
        {
            t_height = value < 0 ? -value : value;
        }
    }

    // Display the dimension of tanks 
    public void DisplayDimension()
    {
        Console.WriteLine("The radius of tank is :" + Radius
                + " and the height of tank is :" + Height);
    }
}

// A derived class AreaOfTank 
// inheriting Tank Class 
class AreaOfTank : Tank
{

    string Color;

    // Constructor 
    public AreaOfTank(string c, double r, double h)
    {

        // from base class 
        Radius = r;
        Height = h;

        // from derived class 
        Color = c;
    }

    // Return area of tank 
    public double Area()
    {
        return 2 * 3.14 * Radius * Height;
    }

    // Display the color of tank 
    public void DisplayColor()
    {
        Console.WriteLine("The Color of tank is "
                                        + Color);
    }
}


class Demo
{

    // Main Method 
    static void Main()
    {

        // Create and initialize the 
        // object of AreaOfTank 
        AreaOfTank t1 = new AreaOfTank("Red", 7.0, 1.0);
        t1.DisplayColor();
        t1.DisplayDimension();
        Console.WriteLine("Area is " + t1.Area());
    }
}
