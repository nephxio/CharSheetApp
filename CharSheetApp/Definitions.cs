using System;
using System.Collections.Generic;
using System.Text;

namespace CharSheetApp
{
    [Serializable]
    public class Discipline
    {
        public int disciplineID;
        public string disciplineName;
        public int rarityLevel;
        public string primaryAttribute;
        public string primaryAbility;
        public List<string> abilityFoci;

        public Discipline()
        {
            disciplineID = 0;
            disciplineName = "";
            rarityLevel = 0;
            primaryAttribute = "";
            primaryAbility = "";
            abilityFoci = new List<string>();
        }

        public Discipline(int ID, string Name, int Rarity, string Attribute, string Ability, List<string> AbilityFoci)
        {
            disciplineID = ID;
            disciplineName = Name;
            rarityLevel = Rarity;
            primaryAttribute = Attribute;
            primaryAbility = Ability;
            abilityFoci = new List<string>(AbilityFoci);
        }
    }

    [Serializable]
    public class DiscID
    {
        public int disciplineID;
        public string disciplineName;

        public DiscID()
        {
            disciplineID = 0;
            disciplineName = "";
        }

        public DiscID(int ID, string Name)
        {
            disciplineID = ID;
            disciplineName = Name;
        }
    }

    public class Clan
    {
        public int clanID;
        public string clanName;
        public List<DiscID> inClanDisciplines;
        public string weaknessDesc;

        public Clan()
        {
            clanID = 0;
            clanName = "";
            inClanDisciplines = new List<DiscID>();
            weaknessDesc = "";
        }

        public Clan(int ClanID, string ClanName, List<DiscID> InClanDisciplines, string WeaknessDesc)
        {
            clanID = ClanID;
            clanName = ClanName;
            inClanDisciplines = InClanDisciplines;
            weaknessDesc = WeaknessDesc;
        }
    }

    [Serializable]
    public class Bloodline
    {
        public int bloodlineID;
        public string bloodlineName;
        public string parentClanName;
        public IDName meritID;
        public List<IDName> inClanDisciplines;
        public bool additionalPath;
        public string weaknessOneDesc;
        public string weaknessTwoDesc;

        public Bloodline()
        {
            bloodlineID = 0;
            bloodlineName = "";
            parentClanName = "";
            meritID = new IDName();
            inClanDisciplines = new List<IDName>();
            additionalPath = false;
            weaknessOneDesc = "";
            weaknessTwoDesc = "";
        }

        public Bloodline(int BloodlineID, string BloodlineName, string ParentClanName, IDName MeritID, List<IDName> InClanDisciplines, bool AdditionalPath, string WeaknessOneDesc, string WeaknessTwoDesc)
        {
            bloodlineID = BloodlineID;
            bloodlineName = BloodlineName;
            parentClanName = ParentClanName;
            meritID = MeritID;
            inClanDisciplines = InClanDisciplines;
            additionalPath = AdditionalPath;
            weaknessOneDesc = WeaknessOneDesc;
            weaknessTwoDesc = WeaknessTwoDesc;
        }
    }

    [Serializable]
    public class IDName
    {
        public int abilityID;
        public string abilityName;

        public IDName()
        {
            abilityID = 0;
            abilityName = "";
        }

        public IDName(int ID, string Name)
        {
            abilityID = ID;
            abilityName = Name;
        }
    }

    [Serializable]
    public class Merit
    {
        public int meritID;
        public string meritName;
        public int clanMeritID;
        public int cost;

        public Merit()
        {
            meritID = 0;
            meritName = "";
            clanMeritID = 0;
            cost = 0;
        }

        public Merit(int ID, string Name, int Clan, int Cost)
        {
            meritID = ID;
            meritName = Name;
            clanMeritID = Clan;
            cost = Cost;
        }
    }

    [Serializable]
    public class Flaw
    {
        public int flawID;
        public string flawName;
        public int cost;

        public Flaw()
        {
            flawID = 0;
            flawName = "";
            cost = 0;
        }

        public Flaw(int ID, string Name, int Cost)
        {
            flawID = ID;
            flawName = Name;
            cost = Cost;
        }
    }

    [Serializable]
    public class MoralityPath
    {
        public int pathID;
        public string pathName;
        public int baseCost;
        public int sabbatCost;

        public MoralityPath()
        {
            pathID = 0;
            pathName = "";
            baseCost = 0;
            sabbatCost = 0;
        }

        public MoralityPath(int ID, string Name, int BaseCost, int SabbatCost)
        {
            pathID = ID;
            pathName = Name;
            baseCost = BaseCost;
            sabbatCost = SabbatCost;
        }
    }
}