namespace ConsoleApp1;

public class Car : IGround
{
  public int MaxSpeed { get; }
  private string Name { get; }
  
  public Car(int maxSpeed, string name)
  {
    MaxSpeed = maxSpeed;
    Name = name;
  }
  
  public void Ride()
  {
    Console.WriteLine($"Машина '{Name}' едет со скоростью до {MaxSpeed} км/ч");
  }
}