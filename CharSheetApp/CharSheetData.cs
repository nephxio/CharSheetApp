using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharSheetApp
{
    [Serializable]
    public class CharSheetData
    {
        public HeaderData headers;
        public List<AttributeData> attributes;
        public List<AbilityData> abilities;
        public List<AbilityData> backgrounds;
        public List<DisciplineData> disciplines;
        public List<Merit> merits;
        public List<Flaw> flaws;

        public CharSheetData()
        {
            headers = new HeaderData();
            attributes = new List<AttributeData>() { new AttributeData(new IDName(1, "Physical"), new IDName(0, ""), 0), 
                                                     new AttributeData(new IDName(2, "Social"), new IDName(0, ""), 0), 
                                                     new AttributeData(new IDName(3, "Mental"), new IDName(0, ""), 0) };
            abilities = new List<AbilityData>();
            backgrounds = new List<AbilityData>();
            disciplines = new List<DisciplineData>();
            merits = new List<Merit>();
            flaws = new List<Flaw>();
        }
    }

    [Serializable]
    public class HeaderData
    {
        //Player data
        public string playerName;
        public string playerEmail;
        public string membershipID;
        public int creationMC;
        public int currentMC;
        public string directST;
        public string directSTEmail;
        public string directCoord;
        public string directCoordEmail;
        public string domainID;
        public string regionID;
        public string countryID;

        //Character data
        public bool isNPC;
        public System.DateTime creationDate;
        public string charName;
        public string charClan;
        public string charSect;
        public string charPronouns;
        public string charArchetype;
        public string nativeLanguage;
        public Morality moralityPathInfo;
        public string embraceDate;

        public HeaderData()
        {
            this.playerName = "";
            this.playerEmail = "";
            this.membershipID = "";
            this.creationMC = 0;
            this.currentMC = 0;
            this.directST = "";
            this.directSTEmail = "";
            this.directCoord = "";
            this.directCoordEmail = "";
            this.domainID = "";
            this.regionID = "";
            this.countryID = "";
            this.isNPC = false;
            this.creationDate = new System.DateTime();
            this.charName = "";
            this.charClan = "";
            this.charSect = "";
            this.charPronouns = "";
            this.charArchetype = "";
            this.nativeLanguage = "";
            this.moralityPathInfo = new Morality();
            this.embraceDate = "";
        }
    }

    [Serializable]
    public class AttributeData 
    {
        public IDName attributeInfo;
        public IDName focusInfo;
        public int level;

        public AttributeData()
        {
            attributeInfo = new IDName();
            focusInfo = new IDName();
            level = 0;
        }

        public AttributeData(IDName AttributeInfo, IDName FocusInfo, int Level)
        {
            attributeInfo = AttributeInfo;
            focusInfo = FocusInfo;
            level = Level;
        }
    }

    [Serializable]
    public class AbilityData : IDName
    {
        public int level;
        public List<string> specialization;

        public AbilityData() : base()
        {
            level = 0;
            specialization = new List<string>();
        }

        public AbilityData(int Level, List<string> Specialization) : base()
        {
            level = Level;
            specialization = Specialization;
        }
    }

    [Serializable]
    public class DisciplineData : Discipline
    {
        public int level;

        public DisciplineData() : base()
        {
            level = 0;
        }

        public DisciplineData(int Level) : base()
        {
            level = Level;
        }
    }

    [Serializable]
    public class Morality : MoralityPath
    {
        public int level;

        public Morality() : base()
        {
            level = 0;
        }
    }
}
