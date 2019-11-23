using System;
using System.Collections.Generic;
using System.Text;

namespace CharSheetApp
{
    public class Discipline
    {
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

        public int DisciplineID
        {
            get { return disciplineID; }
            set { disciplineID = value; }
        }

        public string DisciplineName
        {
            get { return disciplineName; }
            set { disciplineName = value; }
        }

        public int RarityLevel
        {
            get { return rarityLevel; }
            set { rarityLevel = value; }
        }

        public string PrimaryAttribute
        {
            get { return primaryAttribute; }
            set { primaryAttribute = value; }
        }

        public string PrimaryAbility
        {
            get { return primaryAbility; }
            set { primaryAbility = value; }
        }
        
        public List<string> AbilityFoci
        {
            get { return abilityFoci; }
            set { abilityFoci = value; }
        }


        protected int             disciplineID;
        protected string          disciplineName;
        protected int             rarityLevel;
        protected string          primaryAttribute;
        protected string          primaryAbility;
        protected List<string>    abilityFoci;

    }

    public class DiscID
    {
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

        protected int     disciplineID;
        protected string  disciplineName;
    }

    public class Clan
    {
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

        public int ClanID
        {
            get { return clanID; }
            set { clanID = value; }
        }

        public string ClanName
        {
            get { return clanName; }
            set { clanName = value; }
        }

        public List<DiscID> InClanDisciplines
        {
            get { return inClanDisciplines; }
            set { inClanDisciplines = value; }
        }

        public string WeaknessDesc
        {
            get { return weaknessDesc; }
            set { weaknessDesc = value; }
        }

        protected int             clanID;
        protected string          clanName;
        protected List<DiscID>    inClanDisciplines;
        protected string          weaknessDesc;
    }

    public class Bloodline
    {
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

        public int BloodlineID
        {
            get { return bloodlineID; }
            set { bloodlineID = value; }
        }

        public string BloodlineName
        {
            get { return bloodlineName; }
            set { bloodlineName = value; }
        }

        public string ParentClanName
        {
            get { return parentClanName; }
            set { parentClanName = value; }
        }

        public IDName MeritID
        {
            get { return meritID; }
            set { meritID = value; }
        }

        public List<IDName> InClanDisciplines
        {
            get { return inClanDisciplines; }
            set { inClanDisciplines = value; }
        }

        public bool AdditionalPath
        {
            get { return additionalPath; }
            set { additionalPath = value; }
        }

        public string WeaknessOneDesc
        {
            get { return weaknessOneDesc; }
            set { weaknessOneDesc = value; }
        }

        public string WeaknessTwoDesc
        {
            get { return weaknessTwoDesc; }
            set { weaknessTwoDesc = value; }
        }

        protected int             bloodlineID;
        protected string          bloodlineName;
        protected string          parentClanName;
        protected IDName          meritID;
        protected List<IDName>    inClanDisciplines;
        protected bool            additionalPath;
        protected string          weaknessOneDesc;
        protected string          weaknessTwoDesc;
    }

    public class IDName
    {
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

        public int AbilityID
        {
            get { return abilityID; }
            set { abilityID = value; }
        }

        public string AbilityName
        {
            get { return abilityName; }
            set { abilityName = value; }
        }

        protected int     abilityID;
        protected string  abilityName;
    }

    [Serializable]
    public class Merit
    {
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

        public int MeritID
        {
            get { return meritID; }
            set { meritID = value; }
        }

        public string MeritName
        {
            get { return meritName; }
            set { meritName = value; }
        }

        public int ClanMeritID
        {
            get { return clanMeritID; }
            set { clanMeritID = value; }
        }

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        protected int meritID;
        protected string meritName;
        protected int clanMeritID;
        protected int cost;
    }

    [Serializable]
    public class Flaw
    {
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

        public int FlawID
        {
            get { return flawID; }
            set { flawID = value; }
        }

        public string FlawName
        {
            get { return flawName; }
            set { flawName = value; }
        }

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        protected int flawID;
        protected string flawName;
        protected int cost;
    }
}