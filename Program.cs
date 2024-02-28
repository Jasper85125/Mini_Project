using System.Diagnostics;
using System.Runtime.InteropServices;

public static class Program
{
    public static void Main()
    {
        //make compass
        Compass compass1 = new Compass(north: "Y", east: "N", south: "N", west: "N");

        Console.WriteLine("Welcome to our game what is your name.");
        string name_of_player = Console.ReadLine();
        Player player = new(5, 1, 1, 10, name_of_player);

        Console.WriteLine($"Welcome {player.Name}");

        while(player.CurrentLocation == 1)
        {
            //make location
            //Location home = new Location(1, "Home", "Your house. You really need to clean up the place.", null, null);

            //draw compass
            compass1.DrawCompass();

            //start the writing
            Console.WriteLine("You are currently home what would you like to do.");
            Console.WriteLine("1: look around");
            Console.WriteLine("2: leave the house");
            Console.WriteLine("3: go back to bed");
            string choice1 = Console.ReadLine();
            if(choice1 == "1")
            {
                Console.WriteLine(World.LocationByID(player.CurrentLocation).Description);
            }
            else if(choice1 == "2")
            {
                Console.WriteLine("you open the door and walk to Town square");
                //World.LocationByID(player.CurrentLocation.LocationToNorth);
                Console.WriteLine(player.CurrentLocation);
            }
            else if(choice1 == "3")
            {
                Console.WriteLine("You go back to bed, but cant sleep better go do somting");
            }
            else
            {
                Console.WriteLine("That is not a valid input");
            }
        }
        

        GoNorth = "Y";
        GoEast = "Y";
        GoSouth = "Y";
        GoWest = "Y";
        Compass compass2 = new Compass(north: GoNorth, east: GoEast, south: GoSouth, west: GoWest);
        compass2.DrawCompass();

        Location Town = new Location(2, "Town square", "You see a fountain.", null, null);
        Console.WriteLine(Town.Description);
        Console.WriteLine(player);
    }
}