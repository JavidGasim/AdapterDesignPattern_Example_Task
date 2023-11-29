using System;

public class Square
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public double CalculateArea()
    {
        return side * side;
    }
}

public interface IShape
{
    double GetArea();
}

public class SquareAdapter : IShape
{
    private Square square;

    public SquareAdapter(double side)
    {
        this.square = new Square(side);
    }

    public double GetArea()
    {
        return square.CalculateArea();
    }
}

class Program
{
    static void Main()
    {
        IShape squareAdapter = new SquareAdapter(5.0);
        Console.WriteLine("Area: " + squareAdapter.GetArea());
    }
}