using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CharSheetApp
{
    public static class StaticGameData
    {
        static StaticGameData()
        {

        }

        public static void SerializeCharacterSheet(string Filename, CharSheetData CharSheet)
        {
            System.IO.Stream dataStream = File.OpenWrite(Filename);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(dataStream, CharSheet);

            dataStream.Flush();
            dataStream.Close();
            dataStream.Dispose();
        }

        public static CharSheetData DeserializeCharacterSheet(string Filename)
        {

            BinaryFormatter formatter = new BinaryFormatter();

            FileStream fs = new FileStream(Filename, FileMode.Open);
            object obj = formatter.Deserialize(fs);

            CharSheetData characterSheet = (CharSheetData)obj;
            fs.Flush();
            fs.Close();
            fs.Dispose();


            return characterSheet;
        }

        private static SQLiteConnection OpenDBConnection()
        {
            SQLiteConnection conn = new SQLiteConnection(@"DataSource=..\Resources\data.db");

            try
            {
                conn.Open();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());

            }

            return conn;
        }

        public static List<Discipline> LoadDisciplineData()
        {
            List<Discipline> disciplineList = new List<Discipline>();

            SQLiteConnection conn = OpenDBConnection();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT IFNULL(D.DisciplineID, 0), IFNULL(D.DisciplineName, ''), IFNULL(D.RarityLevel, 0), IFNULL(At.AttributeName, '') AS 'Primary Attribute', IFNULL(Ab.AbilityName, '') AS 'Primary Ability', IFNULL(F1.FocusName, '') AS 'Level 1 Focus', " +
                "IFNULL(F2.FocusName, '') AS 'Level 2 Focus', IFNULL(F3.FocusName, '') AS 'Level 3 Focus', IFNULL(F4.FocusName, '') AS 'Level 4 Focus', IFNULL(F5.FocusName, '') AS 'Level 5 Focus' " +
                "FROM Disciplines AS D " +
                "LEFT JOIN Attributes AS At ON D.PrimaryAttributeID = At.AttributeID " +
                "LEFT JOIN Abilities AS Ab ON D.PrimaryAbilityID = Ab.AbilityID " +
                "LEFT JOIN Foci AS F1 ON D.LevelOneFocusID = F1.FocusID " +
                "LEFT JOIN Foci AS F2 ON D.LevelTwoFocusID = F2.FocusID " +
                "LEFT JOIN Foci AS F3 ON D.LevelThreeFocusID = F3.FocusID " +
                "LEFT JOIN Foci AS F4 ON D.LevelFourFocusID = F4.FocusID " +
                "LEFT JOIN Foci As F5 ON D.LevelFiveFocusID = F5.FocusID";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                disciplineList.Add(new Discipline(sqlite_datareader.GetInt32(0), sqlite_datareader.GetString(1), sqlite_datareader.GetInt32(2), sqlite_datareader.GetString(3), sqlite_datareader.GetString(4), 
                    new List<string>() { sqlite_datareader.GetString(5), sqlite_datareader.GetString(6), sqlite_datareader.GetString(7), sqlite_datareader.GetString(8), sqlite_datareader.GetString(9) }));
            }

            try
            {
                conn.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

            return disciplineList;

        }

        public static List<Clan> LoadClanData()
        {
            List<Clan> clanData = new List<Clan>();
            SQLiteConnection conn = OpenDBConnection();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT IFNULL(C.ClanID, 0), IFNULL(C.ClanName, ''), IFNULL(D1.DisciplineID,0), IFNULL(D1.DisciplineName, '') AS 'First In-Clan', IFNULL(D2.DisciplineID,0), " +
                                     "IFNULL(D2.DisciplineName, '') AS 'Second In-Clan', IFNULL(D3.DisciplineID, 0), IFNULL(D3.DisciplineName, '') AS 'Third In-Clan', IFNULL(W.WeaknessDesc, '') AS 'Weakness' " +
                                     "FROM Clans AS C " +
                                     "LEFT JOIN Disciplines AS D1 ON C.FirstInClanID = D1.DisciplineID " +
                                     "LEFT JOIN Disciplines AS D2 ON C.SecondInClanID = D2.DisciplineID " +
                                     "LEFT JOIN Disciplines AS D3 ON C.ThirdInClanID = D3.DisciplineID " +
                                     "LEFT JOIN ClanWeaknesses AS W ON C.WeaknessID = W.WeaknessID";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while(sqlite_datareader.Read())
            {
                clanData.Add(new Clan(sqlite_datareader.GetInt32(0), sqlite_datareader.GetString(1), new List<DiscID>() { new DiscID(sqlite_datareader.GetInt32(2), sqlite_datareader.GetString(3)), new DiscID(sqlite_datareader.GetInt32(4), sqlite_datareader.GetString(5)),
                    new DiscID(sqlite_datareader.GetInt32(6), sqlite_datareader.GetString(7)) }, sqlite_datareader.GetString(8)));
            }

            try
            {
                conn.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

            return clanData;
        }

        public static List<Bloodline> LoadBloodlineData()
        {
            List<Bloodline> bloodlineData = new List<Bloodline>();
            SQLiteConnection conn = OpenDBConnection();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT IFNULL(C.BloodlineID, 0) AS 'Clan ID', IFNULL(C.BloodlineName, '') AS 'Clan Name', IFNULL(C1.ClanName, '') AS 'Parent Clan',  IFNULL(C.MeritID, 0), IFNULL(M.MeritName, '')," +
                                     "IFNULL(D1.DisciplineID, 0), IFNULL(D1.DisciplineName, '') AS 'First In-Clan', " +
                                     "IFNULL(D2.DisciplineID, 0), IFNULL(D2.DisciplineName, '') AS 'Second In-Clan', " +
                                     "IFNULL(D3.DisciplineID, 0), IFNULL(D3.DisciplineName, '') AS 'Third In-Clan', IFNULL(C.AdditionalPath, False) AS 'Additional Path', " +
                                     "IFNULL(W.WeaknessDesc,''), IFNULL(W2.WeaknessDesc,'') " +
                                     "FROM Bloodlines AS C " +
                                     "LEFT JOIN Clans AS C1 ON c.ParentClanID = C1.ClanID " +
                                     "LEFT JOIN Merits AS M ON C.MeritID = M.MeritID " +
                                     "LEFT JOIN ClanWeaknesses AS W ON C.WeaknessOneID = W.WeaknessID " +
                                     "LEFT JOIN ClanWeaknesses AS W2 ON C.WeaknessTwoID = W2.WeaknessID " +
                                     "LEFT JOIN Disciplines AS D1 ON C.FirstInClanID = D1.DisciplineID " +
                                     "LEFT JOIN Disciplines AS D2 ON C.SecondInClanID = D2.DisciplineID " +
                                     "LEFT JOIN Disciplines AS D3 ON C.ThirdInClanID = D3.DisciplineID";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                try
                {
                    bloodlineData.Add(new Bloodline(sqlite_datareader.GetInt32(0), sqlite_datareader.GetString(1), sqlite_datareader.GetString(2), new IDName(sqlite_datareader.GetInt32(3), sqlite_datareader.GetString(4)), new List<IDName>()
                                { new IDName(sqlite_datareader.GetInt32(5), sqlite_datareader.GetString(6)), new IDName(sqlite_datareader.GetInt32(7), sqlite_datareader.GetString(8)), new IDName(sqlite_datareader.GetInt32(9), sqlite_datareader.GetString(10))},
                                sqlite_datareader.GetString(11) == "True", sqlite_datareader.GetString(12), sqlite_datareader.GetString(13)));
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.ToString());
                }
            }

            try
            {
                conn.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

            return bloodlineData;
        }

        public static Dictionary<int,string> LoadIDNameData(string tableName)
        {
            Dictionary<int, string> IDNameDict = new Dictionary<int, string>();
            SQLiteConnection conn = OpenDBConnection();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM " + tableName;

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while(sqlite_datareader.Read())
            {
                IDNameDict.Add(sqlite_datareader.GetInt32(0), sqlite_datareader.GetString(1));
            }

            try
            {
                conn.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

            return IDNameDict;
        }
    }
}
