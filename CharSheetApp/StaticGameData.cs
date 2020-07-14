using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using MySql.Data.MySqlClient;
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

        private static MySqlConnection OpenDBConnection()
        {
            MySqlConnection conn = new MySqlConnection(@"Server=192.168.1.191; Port=3306; Database=org_info; Uid=philbert; Pwd=jipKxw6pD4");

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

            MySqlConnection conn = OpenDBConnection();

            MySqlDataReader sqlite_datareader;
            MySqlCommand sqlite_cmd;
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
                disciplineList.Add(new Discipline(new DiscID(sqlite_datareader.GetInt32(0), sqlite_datareader.GetString(1)), sqlite_datareader.GetInt32(2), sqlite_datareader.GetString(3), sqlite_datareader.GetString(4), 
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
            MySqlConnection conn = OpenDBConnection();

            MySqlDataReader sqlite_datareader;
            MySqlCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Clan_Data_With_IDs";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while(sqlite_datareader.Read())
            {
                clanData.Add(new Clan(new IDName(sqlite_datareader.GetInt32(0), sqlite_datareader.GetString(1)), new List<DiscID>() { new DiscID(sqlite_datareader.GetInt32(2), sqlite_datareader.GetString(3)), new DiscID(sqlite_datareader.GetInt32(4), sqlite_datareader.GetString(5)),
                    new DiscID(sqlite_datareader.GetInt32(6), sqlite_datareader.GetString(7)) }, new IDName(sqlite_datareader.GetInt32(8), sqlite_datareader.GetString(9))));
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
            MySqlConnection conn = OpenDBConnection();

            MySqlDataReader sqlite_datareader;
            MySqlCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Bloodline_Data_With_IDs";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                try
                {
                    bloodlineData.Add(new Bloodline(new IDName(sqlite_datareader.GetInt32(0), sqlite_datareader.GetString(1)), new IDName(sqlite_datareader.GetInt32(2), sqlite_datareader.GetString(3)), new IDName(sqlite_datareader.GetInt32(4), sqlite_datareader.GetString(5)), new List<IDName>()
                                { new IDName(sqlite_datareader.GetInt32(6), sqlite_datareader.GetString(7)), new IDName(sqlite_datareader.GetInt32(8), sqlite_datareader.GetString(9)), new IDName(sqlite_datareader.GetInt32(10), sqlite_datareader.GetString(11))},
                                sqlite_datareader.GetInt32(12), new IDName(sqlite_datareader.GetInt32(13), sqlite_datareader.GetString(14)), 
                                new IDName(sqlite_datareader.GetInt32(15), sqlite_datareader.GetString(16))));
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

        public static List<MoralityPath> LoadMoralityData()
        {
            List<MoralityPath> data = new List<MoralityPath>();
            MySqlConnection conn = OpenDBConnection();

            MySqlDataReader sqlite_datareader;
            MySqlCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM static_data_path_of_enlightenment";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                data.Add(new MoralityPath(new IDName(sqlite_datareader.GetInt32(0), sqlite_datareader.GetString(1)), sqlite_datareader.GetInt32(2), sqlite_datareader.GetInt32(3)));
            }

            try
            {
                conn.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

            return data;
        }

        public static List<ApprovalItems> LoadApprovalItemsData()
        {
            List<ApprovalItems> data = new List<ApprovalItems>();
            MySqlConnection conn = OpenDBConnection();

            MySqlDataReader sqlite_datareader;
            MySqlCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Approval_Items";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                data.Add(new ApprovalItems(new IDName(sqlite_datareader.GetInt32(0), sqlite_datareader.GetString(1)), new IDName(sqlite_datareader.GetInt32(0), sqlite_datareader.GetString(1))));
            }

            try
            {
                conn.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

            return data;
        }

        public static Dictionary<int,string> LoadIDNameData(string tableName)
        {
            Dictionary<int, string> IDNameDict = new Dictionary<int, string>();
            MySqlConnection conn = OpenDBConnection();

            MySqlDataReader sqlite_datareader;
            MySqlCommand sqlite_cmd;
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
