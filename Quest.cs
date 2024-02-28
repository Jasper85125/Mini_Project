public class Quest
{
    public string Disciption;
    public int ID;
    public string Name;
    public bool QuestCompleted;

    public Quest(int id, string name, string Disciption)
    {
        this.ID = id;
        this.Name = name;
        this.Disciption = Disciption;
        this.QuestCompleted = false;
    }

}