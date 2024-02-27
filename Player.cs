public class player
{
    public int CurrentHitPoints;
    public int CurrentHealthPotions
    public string CurrentLocation;
    public string CurrentWeapon;
    public string MaximumHitPoints;
    public string Name;

    public player(int currentHitPoints, int currentHealthPotions, string currentLocation, string currentWeapon, string maximumHitPoints, string name)
    {
        this.CurrentHitPoints = currentHitPoints;
        this.CurrentHealthPotions = currentHealthPotions;
        this.CurrentLocation = currentLocation;
        this.CurrentWeapon = currentWeapon;
        this.MaximumHitPoints = maximumHitPoints;
        this.Name = name;
    }
}