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

        public DatabaseManager() { }

        public void generateTable() //KIOO
        {
            connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
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
            //string resp = "";
            connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;"); //for MAMP: pwd = root
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

        public void modifyStock(string code)
        {
            this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
            try
            {
                connection.Open();
                MySqlCommand sqlCmd1 = new MySqlCommand("SELECT stock_q FROM stock WHERE code='" + code + "'", connection);
                MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                int stock = 999;
                try
                {
                    while (myReader.Read())
                    {

                        try
                        {
                            Console.WriteLine(myReader.GetString(0));
                            Console.WriteLine(myReader.GetString(0));
                            Console.ReadLine();
                            stock = Convert.ToInt16(myReader.GetString(0));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            throw;
                        }
                    }
                }
                finally
                {
                    myReader.Close();
                    connection.Close();
                }

                stock += 3;
                connection.Open();
                MySqlCommand sqlCmd = new MySqlCommand("UPDATE stock SET stock_q =" + stock + " WHERE code='COR56BL'", connection); // attention il faut mettre les guillemets
                sqlCmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                //voir comment on veut gérer les exceptions
            }
        }

        public double totalPrice(Dictionary<string, int> elements)
        {
            double total_price = 0;
            try
            {
                this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
                connection.Open();
                foreach (string element in elements.Keys)
                {
                    MySqlCommand sqlCmd1 = new MySqlCommand("SELECT client_price FROM stock WHERE code='" + element + "'", connection);
                    MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                    while (myReader.Read())
                    {
                        try
                        {
                            total_price = total_price + (Convert.ToDouble(myReader.GetString(0)) * elements[element]);
                        }
                        catch (Exception ex)
                        {
                            throw;
                        }
                    }
                    myReader.Close();
                }
            }
            catch (MySqlException ex)
            {
                throw; //voir comment on veut gérer les exceptions
            }
            finally
            {
                connection.Close();
            }
            return (total_price);
        }

        public List<string> ElementsInStock(Dictionary<string, int> elements)
        {
            List<string> in_stock = new List<string>();
            try
            {
                this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
                connection.Open();
                foreach (string element in elements.Keys)
                {
                    MySqlCommand sqlCmd1 = new MySqlCommand("SELECT stock_q FROM stock WHERE code='" + element + "'", connection);
                    MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                    while (myReader.Read())
                    {
                        try
                        {
                            if (elements[element] < Convert.ToInt16(myReader.GetString(0)))
                            {
                                in_stock.Add(element);
                            }
                        }
                        catch (Exception ex)
                        {
                            throw;
                        }
                    }
                    myReader.Close();
                }
            }
            catch (MySqlException ex)
            {
                throw; //voir comment on veut gérer les exceptions
            }
            finally
            {
                connection.Close();
            }
            return (in_stock);
        }

        public List<string> ElementsOutOfStock(Dictionary<string, int> elements)
        {
            List<string> out_stock = new List<string>();
            try
            {
                this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
                connection.Open();
                foreach (string element in elements.Keys)
                {
                    MySqlCommand sqlCmd1 = new MySqlCommand("SELECT stock_q FROM stock WHERE code='" + element + "'", connection);
                    MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                    while (myReader.Read())
                    {
                        try
                        {
                            if (elements[element] > Convert.ToInt16(myReader.GetString(0)))
                            {
                                out_stock.Add(element);
                            }
                        }
                        catch (Exception ex)
                        {
                            throw;
                        }
                    }
                    myReader.Close();
                }
            }
            catch (MySqlException ex)
            {
                throw; //voir comment on veut gérer les exceptions
            }
            finally
            {
                connection.Close();
            }
            return (out_stock);
        }

        public List<string> orderedParts(string order_id) //fonction à peaufiner, pour le moment la liste n'est composé que d'un élement max
        {
            this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
            try
            {
                connection.Open();
                MySqlCommand sqlCmd1 = new MySqlCommand("SELECT code FROM orderedpart WHERE order_id='" + order_id + "'", connection);
                MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                string stock = "";
                List<string> liste = new List<string>();
                try
                {
                    while (myReader.Read())
                    {

                        try
                        {
                            stock = myReader.GetString(0);
                            liste.Add(stock);
                            //Console.WriteLine(stock);
                            //Console.WriteLine(liste[0]);
                            //Console.ReadLine();



                        }
                        catch (Exception ex)
                        {
                            throw;
                        }
                    }
                }
                finally
                {
                    myReader.Close();
                    connection.Close();
                }
                return (liste);

            }
            catch (MySqlException ex)
            {
                //voir comment on veut gérer les exceptions
                return null;
            }
        }

        /* @pre: fournir l'id de la commande
           @post: retourne une liste de string contenant: l'id de la commande, la date de commande, la date de livraison, le prix total, le prix déjà payé et l'id du client.
             */

        public List<string> orderDetails(string order_id)
        {
            this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
            try
            {
                connection.Open();
                MySqlCommand sqlCmd1 = new MySqlCommand("SELECT * FROM sale WHERE order_id='" + order_id + "'", connection);
                MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                string stock = "";
                List<string> liste = new List<string>();
                try
                {
                    while (myReader.Read())
                    {

                        try
                        {
                            int i;
                            for (i = 0; i < 6; i++)
                            {
                                stock = myReader.GetString(i);
                                liste.Add(stock);
                            }
                            //liste.ForEach(Console.WriteLine);
                            //Console.WriteLine(liste[0]);
                            //Console.ReadLine();


                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Erreur");
                        }
                    }
                }
                finally
                {
                    myReader.Close();
                    connection.Close();
                }
                return (liste);

            }
            catch (MySqlException ex)
            {
                //voir comment on veut gérer les exceptions
                return null;
            }
        }


        /*
         pre: fournir l'ID du client
         post: retourne une liste contenant l'email, le n° de tel, le pwd, le prenom, le nom et l'adresse.
             */
        public List<string> clientInfo(string client_id)
        {
            this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
            try
            {
                connection.Open();
                MySqlCommand sqlCmd1 = new MySqlCommand("SELECT * FROM client WHERE client_id='" + client_id + "'", connection);
                MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                string stock = "";
                List<string> liste = new List<string>();
                try
                {
                    while (myReader.Read())
                    {

                        try
                        {
                            int i;
                            for (i = 1; i < 7; i++)
                            {
                                stock = myReader.GetString(i);
                                liste.Add(stock);
                            }
                            //liste.ForEach(Console.WriteLine);
                            //Console.ReadLine();


                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Erreur");
                        }
                    }
                }
                finally
                {
                    myReader.Close();
                    connection.Close();
                }
                return (liste);

            }
            catch (MySqlException ex)
            {
                //voir comment on veut gérer les exceptions
                return null;
            }
        }


        public List<string> printOrder(string order_id)
        {

            string client_id = orderDetails(order_id)[5];
            //Console.WriteLine(client_id);

            List<string> liste = new List<string> { };

            liste.AddRange(clientInfo(client_id));
            liste.AddRange(orderDetails(order_id));
            liste.AddRange(orderedParts(order_id));

            liste.ForEach(Console.WriteLine);
            Console.ReadLine();
            return liste;

        }


        //public 
        //{
        //    string cmd = "SELECT price FROM stock WHERE code='"+ code + "'";
        //    commandDB(cmd);
        //    return ();
        //}
    }
}


//code => prix
//code => présent
