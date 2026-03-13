namespace CP4._ООП_ref_out_etc;

public enum DangerLevel
{
  Мирный,
  Нейтральный,
  Агрессивный
}
public class Creature : Artifact
{
  public Creature(string name, string description, int age, DangerLevel dangerLevel, string diet) : base(name, description, age)
  {
    DangerLevel = dangerLevel;
    Diet = diet;
  }

  public DangerLevel DangerLevel { get; private set; }
  public string Diet { get; private set; }

  public override string ToString()
  {
    return base.ToString() + $", Уровень опасности: {DangerLevel}\n" +
           $" Питается: {Diet}";
  }
}