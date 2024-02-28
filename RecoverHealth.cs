public class RecoverHealth
{
    public int CurrentHitPoints;
    public int CurrentHealthPotions;
    public int MaximumHitPoints;
    public int HealthPerPotion;

    public RecoverHealth(int currentHitPoints, int currentHealthPotions, int maximumHitPoints, int healthPerPotion = 25)
    {
        this.CurrentHitPoints = currentHitPoints;
        this.CurrentHealthPotions = currentHealthPotions;
        this.MaximumHitPoints = maximumHitPoints;
        this.HealthPerPotion = healthPerPotion;
    }

    public (int, int) UseHealthPotion()
    {
        CurrentHitPoints += HealthPerPotion;    //The potion healing mechanic
        if(CurrentHitPoints > MaximumHitPoints)
        {
            CurrentHitPoints = MaximumHitPoints;
        }
        CurrentHealthPotions--;                 //corrects the amount of potions
        return (CurrentHitPoints, CurrentHealthPotions);
    }

    public int RestAtCamp()
    {
        CurrentHitPoints = MaximumHitPoints;    //reset health to max health
        return CurrentHitPoints;
        // Implementation for resting at camp
    }
}