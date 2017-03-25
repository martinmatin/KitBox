using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace KitBox
{
    class DatabaseManager
    {
        private MySqlConnection connection;

        public DatabaseManager(){}

        public void generateTable()
        {
            connection = new MySqlConnection("server = localhost; uid = root; database = kitboxredo;");
            try
            {
                connection.Open();
                MySqlScript script = new MySqlScript(connection, File.ReadAllText("kitbox.sql"));
                script.Delimiter = "$$";
                script.Execute();
            }
            catch (MySqlException)
            {
                Console.WriteLine("Internal error occurred");
                Console.ReadLine();
            }
            finally
            {
                connection.Close();
            }
        }

        public void populateTable(string table)
        {
            string path = "Table_" + table + ".csv";
            string cmd = "LOAD DATA LOCAL INFILE '" + path + "' INTO TABLE " + table + " FIELDS TERMINATED BY ';' LINES TERMINATED BY '\r\n';";
            commandDB(cmd);
        }

        private void commandDB(string mysqlCmd)
        {
            connection = new MySqlConnection("server = localhost; uid = root; database = kitboxredo;"); //for MAMP: pwd = root
            try
            {
                connection.Open();
                MySqlCommand sqlCmd = new MySqlCommand(mysqlCmd, connection);
                sqlCmd.ExecuteNonQuery();
            }
            catch (MySqlException)
            {
                Console.WriteLine("Internal error occurred");
                Console.ReadLine();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
