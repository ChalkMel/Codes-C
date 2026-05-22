namespace Linq;

class Student
{
  public string Name;
  public string Group;
  public int Age;
  public int CSharpScore;
  public int SqlScore;
  public bool HasPetProject;

  public double Avg => (CSharpScore + SqlScore) / 2.0;
}