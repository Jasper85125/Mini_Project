public class Weapon{
    public int MaximumDamage;
    public int Id;
    public string Name;

    public Weapon(int id, string name, string MaximumDamage)
    {
        this.Id = id;
        this.Name = name;
        this.MaximumDamage = MaximumDamage;
    }
}