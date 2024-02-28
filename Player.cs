public class Player
{
    public int CurrentHitPoints;
    public string CurrentLocation;
    public string CurrentWeapon;
    public string MaximumHitPoints;
    public string Name;

    public Player(int currentHitPoints, string currentLocation, string currentWeapon, string maximumHitPoints, string name)
    {
        this.CurrentHitPoints = currentHitPoints;
        this.CurrentLocation = currentLocation;
        this.CurrentWeapon = currentWeapon;
        this.MaximumHitPoints = maximumHitPoints;
        this.Name = name;
    }
}