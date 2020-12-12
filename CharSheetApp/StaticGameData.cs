using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Core;
using YamlDotNet.Serialization;
using System.Windows.Forms;

namespace CharSheetApp
{
    public static class StaticGameData
    {
        static StaticGameData()
        {

        }

        public static void SerializeCharacterSheet(string Filename, CharSheetData CharSheet)
        {
            var input = new StringReader(Filename);
        }

        public static CharSheetData DeserializeCharacterSheet(string Filename)
        {
            CharSheetData characterSheet = new CharSheetData();

            return characterSheet;
        }

        private static MySqlConnection OpenDBConnection()
        {
            MySqlConnection conn = new MySqlConnection(@"Server=192.168.1.67; Port=3306; Database=org_info; Uid=philbert; Pwd=jipKxw6pD4");

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

            MySqlDataReader mysql_datareader;
            MySqlCommand mysql_cmd;
            mysql_cmd = conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT * FROM Discipline_Data";

            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                disciplineList.Add(new Discipline(new IDName(mysql_datareader.GetInt32(0), mysql_datareader.GetString(1)), mysql_datareader.GetInt32(2), mysql_datareader.GetString(3), mysql_datareader.GetString(4), 
                    new List<string>() { mysql_datareader.GetString(5), mysql_datareader.GetString(6), mysql_datareader.GetString(7), mysql_datareader.GetString(8), mysql_datareader.GetString(9) }));
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

            MySqlDataReader mysql_datareader;
            MySqlCommand mysql_cmd;
            mysql_cmd = conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT * FROM Clan_Data_With_IDs";

            mysql_datareader = mysql_cmd.ExecuteReader();
            while(mysql_datareader.Read())
            {
                clanData.Add(new Clan(new IDName(mysql_datareader.GetInt32(0), mysql_datareader.GetString(1)), new List<IDName>() { new IDName(mysql_datareader.GetInt32(2), mysql_datareader.GetString(3)), new IDName(mysql_datareader.GetInt32(4), mysql_datareader.GetString(5)),
                    new IDName(mysql_datareader.GetInt32(6), mysql_datareader.GetString(7)) }, new IDName(mysql_datareader.GetInt32(8), mysql_datareader.GetString(9))));
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

            MySqlDataReader mysql_datareader;
            MySqlCommand mysql_cmd;
            mysql_cmd = conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT * FROM Bloodline_Data_With_IDs";

            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                try
                {
                    bloodlineData.Add(new Bloodline(new IDName(mysql_datareader.GetInt32(0), mysql_datareader.GetString(1)), new IDName(mysql_datareader.GetInt32(2), mysql_datareader.GetString(3)), new IDName(mysql_datareader.GetInt32(4), mysql_datareader.GetString(5)), new List<IDName>()
                                { new IDName(mysql_datareader.GetInt32(6), mysql_datareader.GetString(7)), new IDName(mysql_datareader.GetInt32(8), mysql_datareader.GetString(9)), new IDName(mysql_datareader.GetInt32(10), mysql_datareader.GetString(11))},
                                mysql_datareader.GetInt32(12), new IDName(mysql_datareader.GetInt32(13), mysql_datareader.GetString(14)), 
                                new IDName(mysql_datareader.GetInt32(15), mysql_datareader.GetString(16))));
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

            MySqlDataReader mysql_datareader;
            MySqlCommand mysql_cmd;
            mysql_cmd = conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT * FROM static_data_path_of_enlightenment";

            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                data.Add(new MoralityPath(new IDName(mysql_datareader.GetInt32(0), mysql_datareader.GetString(1)), mysql_datareader.GetInt32(2), mysql_datareader.GetInt32(3)));
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

            MySqlDataReader mysql_datareader;
            MySqlCommand mysql_cmd;
            mysql_cmd = conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT * FROM Approval_Items";

            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                data.Add(new ApprovalItems(new IDName(mysql_datareader.GetInt32(0), mysql_datareader.GetString(1)), new IDName(mysql_datareader.GetInt32(0), mysql_datareader.GetString(1))));
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

        public static List<IDName> LoadIDNameData(string tableName)
        {
            List<IDName> IDNameDict = new List<IDName>();
            MySqlConnection conn = OpenDBConnection();

            MySqlDataReader mysql_datareader;
            MySqlCommand mysql_cmd;
            mysql_cmd = conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT * FROM " + tableName;

            mysql_datareader = mysql_cmd.ExecuteReader();
            while(mysql_datareader.Read())
            {
                IDNameDict.Add(new IDName(mysql_datareader.GetInt32(0), mysql_datareader.GetString(1)));
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

        public static List<string> FixTable(string tableName)
        {
            List<string> IDNameDict = new List<string>();
            MySqlConnection conn = OpenDBConnection();

            MySqlDataReader mysql_datareader;
            MySqlCommand mysql_cmd;
            mysql_cmd = conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT * FROM " + tableName;

            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                IDNameDict.Add(mysql_datareader.GetString(1));
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

        public static List<int> FixTableInt(string tableName, int column)
        {
            List<int> IDNameDict = new List<int>();
            MySqlConnection conn = OpenDBConnection();

            MySqlDataReader mysql_datareader;
            MySqlCommand mysql_cmd;
            mysql_cmd = conn.CreateCommand();
            mysql_cmd.CommandText = "SELECT * FROM " + tableName;

            mysql_datareader = mysql_cmd.ExecuteReader();
            while (mysql_datareader.Read())
            {
                IDNameDict.Add(mysql_datareader.GetInt32(column));
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

        public static List<string> WriteFixToTable(string tableName, string IDColumn, string dataColumn, List<string> columnData, int count)
        {
            List<string> IDNameDict = new List<string>();
            
            MySqlDataReader mysql_datareader;
            MySqlCommand mysql_cmd;

            for (int x = 0; x < count; x++)
            {
                MySqlConnection conn = OpenDBConnection();
                mysql_cmd = conn.CreateCommand();

                mysql_cmd.CommandText = "UPDATE " + tableName + " SET " + dataColumn + " = " + "'" + columnData[x] + "'" + " WHERE " + IDColumn + " = " + (x + 1);

                mysql_datareader = mysql_cmd.ExecuteReader();
                conn.Close();
            }

            try
            {
                //conn.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

            return IDNameDict;
        }

        public static List<int> WriteFixToTableInt(string tableName, string IDColumn, string dataColumn, List<int> columnData, int count)
        {
            List<int> IDNameDict = new List<int>();

            MySqlDataReader mysql_datareader;
            MySqlCommand mysql_cmd;

            for (int x = 0; x < count; x++)
            {
                MySqlConnection conn = OpenDBConnection();
                mysql_cmd = conn.CreateCommand();

                mysql_cmd.CommandText = "UPDATE " + tableName + " SET " + dataColumn + " = " + "'" + columnData[x] + "'" + " WHERE " + IDColumn + " = " + (x + 1);

                mysql_datareader = mysql_cmd.ExecuteReader();
                conn.Close();
            }

            try
            {
                //conn.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

            return IDNameDict;
        }
    }
}
