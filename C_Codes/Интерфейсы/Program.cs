using ConsoleApp1;

Car car = new Car(180,"BatMobile");
car.Ride();

Amphibius amphibius = new Amphibius(120,"Amphicar" );
amphibius.Sail();
amphibius.Fly();

Submarine submarine = new Submarine(45,"Акула", true);
submarine.Sail();
submarine.IsUnderwater = true;
submarine.Sail();