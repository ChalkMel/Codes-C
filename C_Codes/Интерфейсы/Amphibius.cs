namespace ConsoleApp1;

public class Amphibius : IWaterborne, IFlying
{
  public int MaxSpeed { get; }
  private string Name { get; }
  
  public Amphibius(int maxSpeed, string name)
  {
    MaxSpeed = maxSpeed;
    Name = name;
  }
  public void Sail()
  {
    int waterSpeed = MaxSpeed / 10;
    Console.WriteLine($"Амфибия '{Name}' плывет со скоростью {waterSpeed} км/ч");
  }
  public void Fly()
  {
    Console.WriteLine($"Амфибия '{Name}' летит со скоростью до {MaxSpeed} км/ч");
  }
}