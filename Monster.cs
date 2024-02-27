public class Monster
{
    public int healthpoints = 50;
    public int attackpoints = 5;
    public string name_monster = "Rat";

    public void attack(int dmg)
    {
        healthpoints -= dmg;
    }

    public void monter_attack()
    {
        break;
    }
}