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

        public DatabaseManager() { } //init

        public void generateTable()
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

        public void modifyStock(string code, string field, string newValue)
        {
            this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
            try
            {
                connection.Open();
                MySqlCommand sqlCmd1 = new MySqlCommand("SELECT " + field + " FROM stock WHERE code='" + code + "'", connection);
                MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                int stock = 0;
                float stock_ = 0;
                try
                {
                    while (myReader.Read())
                    {

                        try
                        {
                            //Console.WriteLine(myReader.GetString(0));
                            //Console.WriteLine(myReader.GetString(0));
                            Console.ReadLine();
                            //stock = Convert.ToInt16(myReader.GetString(0));
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
                try
                {
                    stock += Int32.Parse(newValue);
                    connection.Open();
                    MySqlCommand sqlCmd = new MySqlCommand("UPDATE stock SET " + field + " =" + stock + "  WHERE code='" + code + "'", connection); // attention il faut mettre les guillemets
                    sqlCmd.ExecuteNonQuery();
                }
                catch
                {
                    stock_ += float.Parse(newValue);
                    stock_ = (float)((int)(stock_ * 100f)) / 100f;

                    connection.Open();
                    MySqlCommand sqlCmd = new MySqlCommand("UPDATE stock SET " + field + " =" + newValue + "  WHERE code='" + code + "'", connection); // attention il faut mettre les guillemets
                    sqlCmd.ExecuteNonQuery();
                }

            }
            catch (MySqlException ex)
            {
                //voir comment on veut gérer les exceptions
            }
        }




        public List<string> stockDetail(string code)
         {
             this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
             try
             {
                 connection.Open();
                 MySqlCommand sqlCmd1 = new MySqlCommand("SELECT * FROM stock WHERE code='" + code + "'", connection);
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
                             for (i = 1; i< 4; i++)
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

        public Dictionary<string, int> myStock(Dictionary<string, int> elements, string typee)
        {
            Dictionary<string, int> stock = new Dictionary<string, int>();
            int missing;
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
                        if (typee.Equals("out"))
                        {
                            if (elements[element] > Convert.ToInt16(myReader.GetString(0)))
                            {
                                missing = elements[element] - Convert.ToInt16(myReader.GetString(0));
                                stock.Add(element, missing);
                            }
                        }
                        else
                        {
                            if (elements[element] < Convert.ToInt16(myReader.GetString(0)))
                            {
                                missing = Convert.ToInt16(elements[element]);
                                stock.Add(element, missing);
                            }
                        }
                    }
                    myReader.Close();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
                throw; //voir comment on veut gérer les exceptions
            }
            finally
            {
                connection.Close();
            }
            return (stock);
        }

        /*
        public Dictionary<string, int> ElementsInStock(Dictionary<string, int> elements) //renvoyer dico avec clé: code, value: max dispo en bdd
        {
            Dictionary<string, int> in_stock = new Dictionary<string, int>();
            in_stock = myStock(elements, "in");
            return (in_stock);
        }

        public Dictionary<string, int> ElementsOutOfStock(Dictionary<string, int> elements)
        {
            Dictionary<string, int> out_stock = new Dictionary<string, int>();
            out_stock = myStock(elements, "out");
            return (out_stock);
        }
        */
        public string ElementQuantity(string element)
        {
            string quantity;

            try
            {
                this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
                connection.Open();
                MySqlCommand sqlCmd1 = new MySqlCommand("SELECT stock_q FROM stock WHERE code='" + element + "'", connection);
                MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                if (myReader.Read())
                {
                    quantity = myReader.GetString(0);
                }
                else
                {
                    quantity = "0"; //Bonne idée de mettre 0 ???
                }
                myReader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
                throw; //voir comment on veut gérer les exceptions
            }
            finally
            {
                connection.Close();
            }

            return (quantity);
        }

        public List<Dictionary<string, int>> ElementsInStock(Dictionary<string, int> elements)
        {
            Dictionary<string, int> available_stock = new Dictionary<string, int>();
            Dictionary<string, int> not_in_stock = new Dictionary<string, int>();
            List<Dictionary<string, int>> elements_vs_stock = new List<Dictionary<string, int>>();

            foreach (string element in elements.Keys)
            {
                if (elements[element] <= Convert.ToInt16(ElementQuantity(element)))
                {
                    available_stock.Add(element, elements[element]);
                }
                else
                {
                    if (Convert.ToInt16(ElementQuantity(element)) != 0)
                    {
                        available_stock.Add(element, Convert.ToInt16(ElementQuantity(element)));
                        not_in_stock.Add(element, elements[element] - Convert.ToInt16(ElementQuantity(element)));
                    }
                    else
                    {
                        not_in_stock.Add(element, elements[element]);
                    }
                }
            }
            elements_vs_stock.Add(available_stock);
            elements_vs_stock.Add(not_in_stock);
            return (elements_vs_stock);
        }


        public string login(string Identifiant, string Pwd)
        {
            string logged = "";
            try
            {
                // Ouverture de la connexion SQL
                this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
                connection.Open();

                MySqlCommand sqlCmd1 = new MySqlCommand("SELECT email, phone_number, pwd, client_id from client", connection);
                MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                while (myReader.Read())
                {
                    //Console.WriteLine(myReader.Read());
                    if ((myReader.GetString(0).ToLower() == Identifiant.ToLower() || myReader.GetString(1) == Identifiant) && myReader.GetString(2) == Pwd)
                    {
                        logged = myReader.GetString(3);
                    }
                    else
                    {
                        Console.WriteLine("Pas ==");
                    }
                    Console.ReadLine();
                }
                connection.Close();
            }
            catch
            {
                throw;
            }
            return (logged);
        }

        public bool register(string Email, string PhoneNumber, string Pwd, string Address)
        {
            bool registred = false;
            try
            {
                // Ouverture de la connexion SQL
                this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
                connection.Open();

                MySqlCommand sqlCmd1 = new MySqlCommand("SELECT email, phone_number from client", connection);
                MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                bool new_client = true;
                while (myReader.Read())
                {
                    //Console.WriteLine(myReader.Read());
                    if (myReader.GetString(0).ToLower() == Email.ToLower() || myReader.GetString(1) == PhoneNumber)
                    {
                        new_client = false;
                        Console.WriteLine(myReader.GetString(0));
                        Console.WriteLine(myReader.GetString(1));
                    }
                    else
                    {
                        Console.WriteLine("Pas ==");
                    }
                    Console.ReadLine();
                }
                connection.Close();

                if (new_client == true)
                {
                    // Ouverture de la connexion SQL
                    this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
                    connection.Open();

                    // Création d'une commande SQL en fonction de l'objet connection
                    MySqlCommand cmd = this.connection.CreateCommand();

                    // Requête SQL
                    cmd.CommandText = "INSERT INTO client(email, phone_number, pwd, address) VALUES (@email, @phone_number, @pwd, @address)";

                    // utilisation de l'objet contact passé en paramètre
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@phone_number", PhoneNumber);
                    cmd.Parameters.AddWithValue("@pwd", Pwd);
                    cmd.Parameters.AddWithValue("@address", Address);

                    // Exécution de la commande SQL
                    cmd.ExecuteNonQuery();

                    // Fermeture de la connexion
                    this.connection.Close();
                    registred = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occured");
                Console.WriteLine(ex);

                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
            }
            return (registred);
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

            //liste.ForEach(Console.WriteLine);
            //Console.ReadLine();
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
