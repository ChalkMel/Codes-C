namespace CP4._ООП_ref_out_etc;

public enum RarityLevel
{
  Низкий,
  Средний,
  Высокий
}

public class Mineral : Artifact
{
  public Mineral(string name, string description, int age, double radioactivityLevel, RarityLevel rarity) : base(name, description, age)
  {
    RadioactivityLevel = radioactivityLevel;
    Rarity = rarity;
  }

  public double RadioactivityLevel { get; private set; }
  public RarityLevel Rarity { get; private set; }
  
  public override string ToString()
  {
    return base.ToString() + $", Уровень радиоактивности: {RadioactivityLevel}\n" +
           $" Редкость: {Rarity}";
  }
}