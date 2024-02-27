public class Compass
{
    public string North = "Y";
    public string East =  "Y";
    public string South = "Y";
    public string West = "Y";

    public Compass(string north, string east, string south, string west)
    {
        this.North = north;
        this.East = east;
        this.South = south;
        this.West = west;
    }

    public void DrawCompass()
    {
     //  from line 18 until line 50 is just drawing the compass 
        if (North != "N")
        {
            Console.WriteLine("    N");
            Console.WriteLine("    |");
        }

        if (West != "N" && East == "N")
        {
            Console.WriteLine("W---|");
        }
        else if (West != "N")
        {
            Console.Write("W---|");
        }

        if (East != "N" && West != "N")
        {
            Console.WriteLine("---E");
        }
        else if (East != "N")
        {
            Console.WriteLine("    |---E");
        }

        if (South != "N")
        {
            Console.WriteLine("    |"); 
            Console.WriteLine("    S"); 
        }
    }
}