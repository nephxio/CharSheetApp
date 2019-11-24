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
        private string playerName;
        private string playerEmail;
        private string membershipID;
        private int creationMC;
        private int currentMC;
        private string directST;
        private string directSTEmail;
        private string directCoord;
        private string directCoordEmail;
        private string domainID;
        private string regionID;
        private string countryID;

        //Character data
        private bool isNPC;
        private System.DateTime creationDate;
        private string charName;
        private string charClan;
        private string charGender;
        private string charArchetype;
        private string nativeLanguage;
        private string moralityPath;
        private int moralityLevel;
        private System.DateTime embraceDate;

        public HeaderData()
        {

        }

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public string PlayerEmail
        {
            get { return playerEmail; }
            set { playerEmail = value; }
        }

        public string MembershipID
        {
            get { return membershipID; }
            set { membershipID = value; }
        }

        public int CreationMC
        {
            get { return creationMC; }
            set { creationMC = value; }
        }

        public int CurrentMC
        {
            get { return currentMC; }
            set { currentMC = value; }
        }

        public string DirectST
        {
            get { return directST; }
            set { directST = value; }
        }
        public string DirectSTEmail
        {
            get { return directSTEmail; }
            set { directSTEmail = value; }
        }

        public string DirectCoord
        {
            get { return directCoord; }
            set { directCoord = value; }
        }

        public string DirectCoordEmail
        {
            get { return directCoordEmail; }
            set { directCoordEmail = value; }
        }

        public string DomainID
        {
            get { return domainID; }
            set { domainID = value; }
        }

        public string RegionID
        {
            get { return regionID; }
            set { regionID = value; }
        }

        public string CountryID
        {
            get { return countryID; }
            set { countryID = value; }
        }


    }

    [Serializable]
    public class AttributeData 
    {
        private int attributeID;
        private string attributeName;
        private int focusID;
        private string focusName;
        private int level;

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

        public int AttributeID
        {
            get { return attributeID; }
            set { attributeID = value; }
        }

        public string AttributeName
        {
            get { return attributeName; }
            set { attributeName = value; }
        }

        public int FocusID
        {
            get { return focusID; }
            set { focusID = value; }
        }

        public string FocusName
        {
            get { return focusName; }
            set { focusName = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }
    }

    [Serializable]
    public class AbilityData : IDName
    {
        protected int level;
        protected List<string> specialization;

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

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public List<string> Specialization
        {
            get { return specialization; }
            set { specialization = Specialization; }
        }
    }

    [Serializable]
    public class DisciplineData : Discipline
    {
        protected int level;

        public DisciplineData() : base()
        {
            level = 0;
        }

        public DisciplineData(int Level) : base()
        {
            level = Level;
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }
    }

}
