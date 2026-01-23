namespace ConsoleApp1;

public class Triangle : Shape
{
  private double _sideA;
  private double _sideB;
  private double _sideC;

  public Triangle( double sideA, double sideB, double sideC)
  { 
    _sideA = sideA;
    _sideB = sideB;
    _sideC = sideC;
  }
  
  public override double Area()
  {
    double p = Perimeter() / 2;
    double result = p * (p - _sideA) * (p - _sideB) * (p - _sideC);
    if (result > 0)
      return Math.Sqrt(result);
    return 0;
  }

  public override double Perimeter()
  {
    return  _sideA + _sideB + _sideC;
  }
  
  public override bool Try()
  {
    if ((_sideA <= 0 || _sideB <= 0 || _sideC <= 0) && (_sideA + _sideB <= _sideC && _sideA + _sideC <= _sideB && _sideB + _sideC <= _sideA)) 
      return false;

    return true;
  }
}