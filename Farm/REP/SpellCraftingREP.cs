/*
name: SpellCrafting REP
description: This script will farm SpellCrafting reputation to rank 10.
tags: spell crafting, spellcrafting, rep, spell, spellcraft, rep, rank, reputation
*/
//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreFarms.cs
//cs_include Scripts/CoreAdvanced.cs
using Skua.Core.Interfaces;
public class SpellCraftingREP
{
    public CoreBots Core => CoreBots.Instance;
    public CoreFarms Farm = new();
    public CoreAdvanced Adv = new();

    public void ScriptMain(IScriptInterface bot)
    {
        Core.SetOptions();

        //Adv.BestGear(GenericGearBoost.dmgAll);
        //Adv.BestGear(GenericGearBoost.rep);
        Farm.SpellCraftingREP();

        Core.SetOptions(false);
    }
}
