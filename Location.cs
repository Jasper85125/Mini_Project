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
    public Monster MonsterLivingHere;
    public Quest QuestAvailableHere;

    public Location(int id, string name, string description, string option_1, string option_2)
    {
        this.ID = id;
        this.Name = name;
        this.Description = description;
        this.Option_1 = option_1;
        this.Option_2 = option_2;
    }
}