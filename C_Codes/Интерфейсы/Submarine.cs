namespace ConsoleApp1;

public class Submarine : IUnderwater
{
  public int MaxSpeed { get; }
  public bool IsUnderwater { get; set; }
  private string Name { get; }
  
  public Submarine(int maxSpeed, string name,  bool isUnderwater)
  {
    MaxSpeed = maxSpeed;
    Name = name;
    IsUnderwater = isUnderwater;
  }

  public void Sail()
  {
    Console.WriteLine(IsUnderwater ? $"Подводная лодка '{Name}' плывет под водой на глубине со скоростью до {MaxSpeed} км/ч" : $"Подводная лодка '{Name}' плывет по воде со скоростью до {MaxSpeed} км/ч");
  }
}