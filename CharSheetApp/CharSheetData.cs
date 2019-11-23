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
        public CharSheetData()
        {
            headers = new HeaderData();
            attributes = new List<AttributeData>() { new AttributeData(1, "Physical", 0, ""), new AttributeData(2, "Social", 0, ""), new AttributeData(3, "Mental", 0, "") };
            abilities = new List<AbilityData>();
            backgrounds = new List<AbilityData>();
            disciplines = new List<DisciplineData>();
            merits = new List<Merit>();
            flaws = new List<Flaw>();
        }

        private HeaderData              headers;
        private List<AttributeData>     attributes;
        private List<AbilityData>       abilities;
        private List<AbilityData>       backgrounds;
        private List<DisciplineData>    disciplines;
        private List<Merit>             merits;
        private List<Flaw>              flaws;
    }

    [Serializable]
    public class HeaderData
    {
        public HeaderData()
        {

        }

        //Player data
        private string playerName;
        private string email;
        private string membershipID;
        private int creationMC;
        private int currentMC;
        private string directST;
        private string directSTEmail;
        private string directCoord;
        private string directCoordEmail;
        private string domainID;
        private string regionID;

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



    }

    [Serializable]
    public class AttributeData 
    {
        public AttributeData()
        {
            attributeID = 0;
            attributeName = "";
            focusID = 0;
            focusName = "";
        }

        public AttributeData(int AtID, string AtName, int FocID, string FocName)
        {
            attributeID = AtID;
            attributeName = AtName;
            focusID = FocID;
            focusName = FocName;
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

        private int attributeID;
        private string attributeName;
        private int focusID;
        private string focusName;
    }

    [Serializable]
    public class AbilityData : IDName
    {
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

        protected int level;
        protected List<string> specialization;

    }

    [Serializable]
    public class DisciplineData : Discipline
    {
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

        protected int level;
    }

}
