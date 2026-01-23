namespace ConsoleApp1;

public class Rectangle : Shape
{
  private double _firstSide;
  private double _secondSide;

  public Rectangle(double firstSide, double secondSide)
  {
    _firstSide = firstSide;
    _secondSide = secondSide;
  }
  public override double Area()
  {
    return _firstSide * _secondSide;
  }

  public override double Perimeter()
  {
    return 2 *  _firstSide + 2 * _secondSide;
  }
  
  public override bool Try()
  {
    if (_firstSide <= 0 || _secondSide <= 0)
      return false;
    return true;
  }
}