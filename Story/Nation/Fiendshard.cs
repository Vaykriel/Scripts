//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreStory.cs
//cs_include Scripts/Story/Nation/Originul.cs
using RBot;

public class Fiendshard_Story
{
    public ScriptInterface Bot => ScriptInterface.Instance;
    public CoreBots Core => CoreBots.Instance;
    public CoreStory Story = new CoreStory();
    public Originul_Story Originul = new Originul_Story();

    public void ScriptMain(ScriptInterface bot)
    {
        Core.SetOptions();

        Fiendshard_Questline();

        Core.SetOptions(false);
    }

    public void Fiendshard_Questline()
    {
        if (Core.isCompletedBefore(7898))
            return;

        Story.PreLoad();

        Originul.Originul_Questline();

        // Sneak Attack
        Story.KillQuest(7892, "Fiendshard", "Rogue Fiend");
        Story.MapItemQuest(7892, "Fiendshard", 7983);

        // Fiend-terrogation
        Story.KillQuest(7893, "Fiendshard", "Paladin Fiend");

        // Key Difference Between Human and Fiend
        Story.KillQuest(7894, "Fiendshard", "Paladin Fiend");

        // Unlock the Door
        Story.KillQuest(7895, "Fiendshard", new[] { "Rogue Fiend", "Paladin Fiend", "Void Knight" });
        Story.MapItemQuest(7895, "Fiendshard", 7984);

        // Dirtlicking Guards
        Story.KillQuest(7896, "Fiendshard", "Paladin Fiend");

        // Defeat Dirtlicker
        Story.KillQuest(7897, "Fiendshard", new[] { "Fiend Shard", "Dirtlicker" });

        // Destroy the Fiend Shard
        // Archfiend DeathLord quests can be done without finishing this quest.
        Story.KillQuest(7898, "Fiendshard", new[] { "Nulgath's Fiend Shard", "Paladin Fiend" });
    }

}
