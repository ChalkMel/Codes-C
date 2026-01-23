using ConsoleApp1;

User user = new User("Михаил Петрович", "Mafioso@meme.com","pink1234");

Console.WriteLine(user.Email);
Console.WriteLine(user.Name);

user.ValidatePassword("orange4321");

user.ChangePassword("pink4321", "pinkHatsLover");
user.ChangePassword("pink1234", "pinkHatsLover");