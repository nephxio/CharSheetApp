using System;
using System.Collections.Generic;
using System.Text;

namespace CharSheetApp
{
    [Serializable]
    public class Discipline
    {
        public DiscID discInfo;
        public int rarityLevel;
        public string primaryAttribute;
        public string primaryAbility;
        public List<string> abilityFoci;

        public Discipline()
        {
            discInfo = new DiscID(40, "None");
            rarityLevel = 0;
            primaryAttribute = "";
            primaryAbility = "";
            abilityFoci = new List<string>();
        }

        public Discipline(DiscID DiscInfo, int Rarity, string Attribute, string Ability, List<string> AbilityFoci)
        {
            discInfo = DiscInfo;
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
        public IDName clanInfo;
        public List<DiscID> inClanDisciplines;
        public IDName weaknessInfo;

        public Clan()
        {
            clanInfo = new IDName();
            inClanDisciplines = new List<DiscID>();
            weaknessInfo = new IDName();
        }

        public Clan(IDName ClanInfo, List<DiscID> InClanDisciplines, IDName WeaknessInfo)
        {
            clanInfo = ClanInfo;
            inClanDisciplines = InClanDisciplines;
            weaknessInfo = WeaknessInfo;
        }
    }

    [Serializable]
    public class Bloodline
    {
        public IDName bloodlineInfo;
        public IDName parentClanInfo;
        public IDName meritID;
        public List<IDName> inClanDisciplines;
        public int additionalPath;
        public IDName weaknessOneInfo;
        public IDName weaknessTwoInfo;


        public Bloodline()
        {
            IDName bloodlineInfo = new IDName();
            IDName parentClanInfo = new IDName();
            meritID = new IDName();
            inClanDisciplines = new List<IDName>();
            additionalPath = 0;
            weaknessOneInfo = new IDName();
            weaknessTwoInfo = new IDName();
        }

        public Bloodline(IDName BloodlineInfo, IDName ParentClanInfo, IDName MeritID, List<IDName> InClanDisciplines, int AdditionalPath, IDName WeaknessOneInfo, IDName WeaknessTwoInfo)
        {
            bloodlineInfo = BloodlineInfo;
            parentClanInfo = ParentClanInfo;
            meritID = MeritID;
            inClanDisciplines = InClanDisciplines;
            additionalPath = AdditionalPath;
            weaknessOneInfo = WeaknessOneInfo;
            weaknessTwoInfo = WeaknessTwoInfo;
        }
    }

    [Serializable]
    public class IDName
    {
        public int fieldID;
        public string fieldName;

        public IDName()
        {
            fieldID = 0;
            fieldName = "";
        }

        public IDName(int ID, string Name)
        {
            fieldID = ID;
            fieldName = Name;
        }
    }

    [Serializable]
    public class Merit
    {
        public IDName meritInfo;
        public int clanMeritID;
        public int cost;

        public Merit()
        {
            meritInfo = new IDName();
            clanMeritID = 0;
            cost = 0;
        }

        public Merit(IDName MeritInfo, int Clan, int Cost)
        {
            meritInfo = MeritInfo;
            clanMeritID = Clan;
            cost = Cost;
        }
    }

    [Serializable]
    public class Flaw
    {
        public IDName flawInfo;
        public int cost;

        public Flaw()
        {
            flawInfo = new IDName();
            cost = 0;
        }

        public Flaw(IDName FlawInfo, int Cost)
        {
            flawInfo = FlawInfo;
            cost = Cost;
        }
    }

    [Serializable]
    public class MoralityPath
    {
        public IDName moralityInfo;
        public int baseCost;
        public int sabbatCost;

        public MoralityPath()
        {
            moralityInfo = new IDName();
            baseCost = 0;
            sabbatCost = 0;
        }

        public MoralityPath(IDName MoralityInfo, int BaseCost, int SabbatCost)
        {
            moralityInfo = MoralityInfo;
            baseCost = BaseCost;
            sabbatCost = SabbatCost;
        }
    }

    public class ApprovalItems
    {
        public IDName approvalItemInfo;
        public IDName approvalLevelInfo;

        public ApprovalItems()
        {
            approvalItemInfo = new IDName();
            approvalLevelInfo = new IDName();
        }

        public ApprovalItems(IDName ApprovalItemInfo, IDName ApprovalLevelInfo)
        {
            approvalItemInfo = ApprovalItemInfo;
            approvalLevelInfo = ApprovalLevelInfo;
            
        }
    }
}