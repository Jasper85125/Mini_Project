using System.Diagnostics;
using System.Runtime.InteropServices;

public static class Program
{
    public static void Main()
    {
        string GoNorth = "Y";
        string GoEast = "N";
        string GoSouth = "N";
        string GoWest = "N";
        Compass compass = new Compass(north: GoNorth, east: GoEast, south: GoSouth, west: GoWest);
        compass.DrawCompass();

        Player player = new(5, 1, 1, 10, "Steve");
        // Console.WriteLine(Location home);
        Location home = new Location(1, "Home", "Your house. You really need to clean up the place.", null, null);
        Console.WriteLine(home.Description);
        Console.WriteLine(player);
        Console.WriteLine("");

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

