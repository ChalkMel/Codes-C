namespace ConsoleApp1;

public class Circle : Shape
{
  private double _radius;
  
  public Circle(double radius)
  {
  _radius = radius;
  }
  
  public override double Area()
  {
    return Math.PI * _radius * _radius;
  }

  public override double Perimeter()
  {
    return 2 * Math.PI * _radius;
  }

  public override bool Try()
  {
    if (_radius <= 0)
      return false;
    return true;
  }
}