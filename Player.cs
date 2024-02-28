public class Player
{
    public int CurrentHitPoints;
    public int CurrentLocation;
    public int CurrentWeapon;
    public int MaximumHitPoints;
    public string Name;

    public Player(int currentHitPoints, int currentLocation, int currentWeapon, int maximumHitPoints, string name)
    {
        this.CurrentHitPoints = currentHitPoints;
        this.CurrentLocation = currentLocation;
        this.CurrentWeapon = currentWeapon;
        this.MaximumHitPoints = maximumHitPoints;
        this.Name = name;
    }

    public override string ToString()
    {
        return $"{CurrentLocation}";
    }
}