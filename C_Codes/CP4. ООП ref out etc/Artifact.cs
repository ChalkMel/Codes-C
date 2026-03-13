namespace CP4._ООП_ref_out_etc;

public abstract class Artifact
{
  protected Artifact(string name, string description, int age)
  {
    Name = name;
    Description = description;
    Age = age;
  }

  public string Name {get;}
  public string Description {get; }
  public int Age {get; }
  
  public override string ToString()
  {
    return $"Артефакт: {Name}\n" +
           $"Описание: {Description}\n" +
           $"Предположительный возраст: {Age} лет";
  }
}