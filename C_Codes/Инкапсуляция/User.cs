namespace ConsoleApp1;

public class User
{
  public string Name { get; set; }
  public string Email { get; protected set; }
  private string _password;

  public User(string name, string email, string password)
  {
    Name = name;
    Email = email;
    _password = password;
  }

  public bool ValidatePassword(string password)
  {
    if (_password != password)
      Console.WriteLine("Неверный пароль");
    else
      Console.WriteLine("Пароль был изменён");
    return _password == password;
  }
  
  public void ChangePassword(string oldPassword, string newPassword)
  {
    if (ValidatePassword(oldPassword))
    {
      _password = newPassword;
      Console.WriteLine("Пароль был изменен");
    }
    else
      Console.WriteLine("Неверный прошлый пароль");
  }
}