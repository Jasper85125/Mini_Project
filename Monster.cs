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

    public string Monster_attack_player(Player player)
    {
        player.currentHitPoints -= MaximumDamage;
        return $"The monster did {MaximumDamage} to you";
    }

    public string player_attack_monster(Weapon weapon)
    {
        CurrentHitPoints -= weapon.MaximumDamage;
        return $"You did {weapon.MaximumDamage} damage to the monster";
    }
}