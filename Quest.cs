public static class Main
{
    public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
    public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;
    public const int QUEST_ID_COLLECT_SPIDER_SILK = 3;

    public class Quest
    {
        public int ID { get; }
        public string Name { get; }
        public string Description { get; }

        public Quest(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
    }

    public static List<Quest> Quests = new List<Quest>();

    public static void PopulateQuests()
    {
        Quest clearAlchemistGarden = new Quest(
            QUEST_ID_CLEAR_ALCHEMIST_GARDEN,
            "Clear the alchemist's garden",
            "Kill rats in the alchemist's garden");

        Quest clearFarmersField = new Quest(
            QUEST_ID_CLEAR_FARMERS_FIELD,
            "Clear the farmer's field",
            "Kill snakes in the farmer's field");

        Quest clearSpidersForest = new Quest(
            QUEST_ID_COLLECT_SPIDER_SILK,
            "Collect spider silk",
            "Kill spiders in the spider forest");

        Quests.Add(clearAlchemistGarden);
        Quests.Add(clearFarmersField);
        Quests.Add(clearSpidersForest);
    }

    public static Quest QuestByID(int id)
    {
        foreach (Quest quest in Quests)
        {
            if (quest.ID == id)
            {
                return quest;
            }
        }
        return null;
    }
}
