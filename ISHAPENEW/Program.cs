using System;
using System.Linq;
/*
	author: Selihom kidane
	Sec: DBRSE2102 A
*/

public class Program {

    static void Main(string[] args)
    {
        Console.WriteLine("using constracter: ");
        Console.WriteLine(new Circle(10).calculateArea());
        Console.WriteLine(new Reactangle(10, 20).calculateArea());
        
        Console.WriteLine("by creatting object then assign the radius =10 !!");
        Circle c = new Circle();
        c.Radius = 10;
        Console.WriteLine("the area of a circle: "+ c.calculateArea());
        Console.WriteLine("the pamater of a circle: "+ c.calculatePermimeter());
        Console.WriteLine("by creatting object then assign the length =10 and width =5 !!");

        Reactangle r = new Reactangle();
        r.Height = 10;
        r.Width = 5;
        Console.WriteLine("the area of a reactangle: "+ r.calculateArea());
        Console.WriteLine("the pamater of a reactangle: "+ r.calculatePermimeter());

    }

}

public class Circle: IShape
{
    static double PI = 3.142;
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }
    public Circle(){}
    public double Radius
    {
        get { return _radius; }
        set { _radius = value; }
    }


    public override double calculateArea()
    {
        return Math.Pow(_radius, 2) * PI;
    }

    public override double calculatePermimeter()
    {
        return 2 * PI * _radius;
    }
}
class Reactangle : IShape
{
    private double _width;
    private double _height;
     public double Width
    {
        get { return _width; }
        set { _width = value; }
    }
     public double Height
    {
        get { return _height; }
        set { _height = value; }
    }
    public Reactangle(double width, double height)
    {
        _width = width;
        _height = height;
    }
    public Reactangle(){}
    public override double calculateArea()
    {
        return _width * _height;
    }

    public override double calculatePermimeter()
    {
        return (_width + _height) * 2;
    }
}

public abstract class IShape {

  public abstract double calculateArea();
   public abstract  double calculatePermimeter();
}