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
            attributes = new List<AttributeData>() { new AttributeData(1, "Physical", 0, "", 0), new AttributeData(2, "Social", 0, "", 0), new AttributeData(3, "Mental", 0, "", 0) };
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
        public string charGender;
        public string charArchetype;
        public string nativeLanguage;
        public Morality moralityPathInfo;
        public System.DateTime embraceDate;

        public HeaderData()
        {
            moralityPathInfo = new Morality();
        }
    }

    [Serializable]
    public class AttributeData 
    {
        public int attributeID;
        public string attributeName;
        public int focusID;
        public string focusName;
        public int level;

        public AttributeData()
        {
            attributeID = 0;
            attributeName = "";
            focusID = 0;
            focusName = "";
            level = 0;
        }

        public AttributeData(int AtID, string AtName, int FocID, string FocName, int Level)
        {
            attributeID = AtID;
            attributeName = AtName;
            focusID = FocID;
            focusName = FocName;
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
