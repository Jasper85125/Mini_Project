public class Weapon{
    public int MaximumDamage;
    public int ID;
    public string Name;

    public Weapon(int id, string name, string MaximumDamage)
    {
        this.ID = id;
        this.Name = name;
        this.MaximumDamage = MaximumDamage;
    }
}