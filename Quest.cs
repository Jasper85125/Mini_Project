public class Quest
{
    public string Description;
    public int ID;
    public string Name;
    public bool QuestCompleted;

    public Quest(int id, string name, string Description)
    {
        this.ID = id;
        this.Name = name;
        this.Description = Description;
        this.QuestCompleted = false;
    }

    public void QuestIsCompleted(){
        this.QuestCompleted = true;
        return QuestCompleted;
    }

}