namespace CP4._ООП_ref_out_etc;

public enum TechnologyLevel
{
  Низкий,
  Средний,
  Высокий
}

public enum TechnologyPurpose 
{
  Неизвестно,
  Оружие,
  Инструмент
}
public class Technology: Artifact
{
  public Technology(string name, string description, int age, TechnologyLevel techLevel, TechnologyPurpose purpose) : base(name, description, age)
  {
    TechLevel = techLevel;
    Purpose = purpose;
  }

  public TechnologyLevel TechLevel { get; private set; }
  public TechnologyPurpose Purpose { get; private set; }

  public override string ToString()
  {
    return base.ToString() + $", Уровень технологии: {TechLevel}\n" +
           $" Назначение: {Purpose}";
  }
}