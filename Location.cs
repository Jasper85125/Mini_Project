using System.Security;
using System.Security.Cryptography.X509Certificates;

public class Location
{
    public int ID;
    public string Name;
    public string Description;
    public string Option_1;
    public string Option_2;
    public Location LocationToNorth;
    public Location LocationToEast;
    public Location LocationToSouth;
    public Location LocationToWest;

    public Location(int id, string name, string description, string option_1, string option_2)
    {
        this.ID = id;
        this.Name = name;
        this.Description = description;
        this.Option_1 = option_1;
        this.Option_2 = option_2;
    }

    // public void LocationToNorth(Player player)
    // {
    //     if (this.ID == 1)
    //     {
    //         player.CurrentLocation = 2;
    //     }
    //     else if (this.ID == 2)
    //     {
    //         player.CurrentLocation = 4;
    //     }
    //     else if (this.ID == 4)
    //     {
    //         player.CurrentLocation = 5;
    //     }
    //     else
    //     {
    //         Console.WriteLine("Can't go North");
    //     } 
    // }

    // public void LocationToEast(Player player)
    // {
    //     if (this.ID == 7)
    //     {
    //         player.CurrentLocation = 6;
    //     }
    //     else if (this.ID == 6)
    //     {
    //         player.CurrentLocation = 2;
    //     }
    //     else if (this.ID == 2)
    //     {
    //         player.CurrentLocation = 3;
    //     }
    //     else if (this.ID == 3)
    //     {
    //         player.CurrentLocation = 8;
    //     }
    //     else if (this.ID == 8)
    //     {
    //         player.CurrentLocation = 9;
    //     }
    //     else
    //     {
    //         Console.WriteLine("Can't go East");
    //     } 
    // }

    // public void LocationToSouth(Player player)
    // {
    //     if (this.ID == 5)
    //     {
    //         player.CurrentLocation = 4;
    //     }
    //     else if(this.ID == 4)
    //     {
    //         player.CurrentLocation = 2;
    //     }
    //     else if (this.ID == 2)
    //     {
    //         player.CurrentLocation = 1;
    //     }
    //     else
    //     {
    //         Console.WriteLine("Can't go South");
    //     }
    // }

    // public void LocationToWest(Player player)
    // {
    //     if (this.ID == 9)
    //     {
    //         player.CurrentLocation = 8;
    //     }
    //     else if (this.ID == 8)
    //     {
    //         player.CurrentLocation = 3;
    //     }
    //     else if (this.ID == 3)
    //     {
    //         player.CurrentLocation = 2;
    //     }
    //     else if (this.ID == 2)
    //     {
    //         player.CurrentLocation = 6;
    //     }
    //     else if (this.ID == 6)
    //     {
    //         player.CurrentLocation = 7;
    //     }
    //     else
    //     {
    //         Console.WriteLine("Can't go West");
    //     }  
    // }

    public void QuestAvailableHere()
    {

    }

    public void MonsterLivingHere()
    {

    }
}