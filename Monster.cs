public class Monster
{
    public int CurrentHitPoints;
    public int ID;
    public int MaximumDamage;
    public int MaximumHitPoints;
    public string Name;

    public Monster(int id, string name, int maximumdamage, int maximumhitpoints, int currenthitpoints)
    {
        this.CurrentHitPoints = currenthitpoints;
        this.ID = id;
        this.MaximumDamage = maximumdamage;
        this.MaximumHitPoints = maximumhitpoints;
        this.Name = name;
    }

    public void Monster_attack_player(Player player)
    {
        player.CurrentHitPoints -= MaximumDamage;
    }

    public void player_attack_monster(Weapon weapon)
    {
        CurrentHitPoints -= weapon.MaximumDamage;
    }
}