using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.IO;

/// <summary>
/// Functions which need access to 'Kitbox' database in phpMyAdmin.
/// 
/// If first access to this program please install 'MySql.Data.MySqlClient' package via Nuget
/// 
/// Mamp users only:
/// set password to root as follows: 'pwd = root' in MySqlConnection parameter.
/// or change mamp parameters and set pwd to blank.
/// 
/// </summary>


namespace KitBox
{
    class DatabaseManager
    {
        private MySqlConnection connection;

        public DatabaseManager() { } //init

        // check if the tables already exist in phpMyAdmin
        public bool existTable()
        {
            bool exists = false;
            this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
            try
            {
                connection.Open();
                MySqlCommand sqlCmd1 = new MySqlCommand("SELECT * from stock", connection);
                MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                exists = true;
            }
            catch { }
            return exists;
        }

        //create tables in phpMyAdmin. See Kitbox\bin\Debug\kitbox.sql
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

        //populate tables in phpMyAdmin. See Kitbox\bin\Debug\Table_XXX.csv
        public void populateTable(string table)
        {
            string path = "Table_" + table + ".csv";
            string cmd = "LOAD DATA LOCAL INFILE '" + path + "' INTO TABLE " + table + " FIELDS TERMINATED BY ';' LINES TERMINATED BY '\r\n';";
            commandDB(cmd);
        }

        //execute query given in parameter
        private void commandDB(string mysqlCmd)
        {
            connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
            try
            {
                connection.Open();
                MySqlCommand sqlCmd = new MySqlCommand(mysqlCmd, connection);
                sqlCmd.ExecuteNonQuery();
            }
            catch (MySqlException)
            { }
            finally
            {
                connection.Close();
            }
        }

        //increase stock_q or virtual_stock in table stock
        public void ModifyStock(string code, string field, string newValue)
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
                            Console.ReadLine();
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
                    MySqlCommand sqlCmd = new MySqlCommand("UPDATE stock SET " + field + " =" + stock + "  WHERE code='" + code + "'", connection);
                    sqlCmd.ExecuteNonQuery();
                }
                catch
                {
                    stock_ += float.Parse(newValue);
                    stock_ = (float)((int)(stock_ * 100f)) / 100f;
                    connection.Open();
                    MySqlCommand sqlCmd = new MySqlCommand("UPDATE stock SET " + field + " =" + newValue + "  WHERE code='" + code + "'", connection);
                    sqlCmd.ExecuteNonQuery();
                }

            }
            catch (MySqlException ex)
            { }
        }

        //get every field value from corresponding code in table stock
        public List<string> StockDetail(string code)
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
                            for (i = 1; i < 5; i++)
                            {
                                stock = myReader.GetString(i);
                                liste.Add(stock);
                            }
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
                return null;
            }
        }

        //returns total price of cabinet
        public double TotalPrice(Dictionary<string, int> elements)
        {
            double totalPrice = 0;
            this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
            try
            {
                connection.Open();
                foreach (string element in elements.Keys)
                {
                    MySqlCommand sqlCmd1 = new MySqlCommand("SELECT client_price FROM stock WHERE code='" + element + "'", connection);
                    MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                    while (myReader.Read())
                    {
                        try
                        {
                            totalPrice = totalPrice + (Convert.ToDouble(myReader.GetString(0)) * elements[element]);
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
                throw;
            }
            finally
            {
                connection.Close();
            }
            return (totalPrice);
        }

        //no comment
        public Dictionary<string, int> MyStock(Dictionary<string, int> elements, string typee)
        {
            Dictionary<string, int> stock = new Dictionary<string, int>();
            int missing;
            this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
            try
            {
                connection.Open();
                foreach (string element in elements.Keys)
                {
                    MySqlCommand sqlCmd1 = new MySqlCommand("SELECT real_stock FROM stock WHERE code='" + element + "'", connection);
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
                throw;
            }
            finally
            {
                connection.Close();
            }
            return (stock);
        }

        //returns the difference between real_stock and vitual_stock of an element
        public string ElementQuantity(string element)
        {
            string quantity, quantity2;
            MySqlConnection connection2 = new MySqlConnection("server = localhost; uid = root; database = kitbox;");

            try
            {
                this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
                connection.Open();
                connection2.Open();
                MySqlCommand sqlCmd1 = new MySqlCommand("SELECT real_stock FROM stock WHERE code='" + element + "'", connection);
                MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                MySqlCommand sqlCmd2 = new MySqlCommand("SELECT virtual_stock FROM stock WHERE code='" + element + "'", connection2);
                MySqlDataReader myReader2 = sqlCmd2.ExecuteReader();
                if (myReader.Read() && myReader2.Read())
                {
                    quantity = myReader.GetString(0);
                    quantity2 = myReader2.GetString(0);

                }
                else
                {
                    quantity = "0";
                    quantity2 = "0";

                }
                myReader.Close();
                myReader2.Close();

            }
            catch (MySqlException ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
                connection2.Close();

            }
            int result = Convert.ToInt32(quantity) - Convert.ToInt32(quantity2);
            return (result.ToString());
        }

        //returns list of dictionnaries of available elements and missing elements
        public List<Dictionary<string, int>> ElementsInStock(Dictionary<string, int> elements)
        {
            Dictionary<string, int> availableStock = new Dictionary<string, int>();
            Dictionary<string, int> notInStock = new Dictionary<string, int>();
            List<Dictionary<string, int>> elementsVsStock = new List<Dictionary<string, int>>();

            foreach (string element in elements.Keys)
            {
                int i1 = elements[element];
                int i2 = Convert.ToInt16(ElementQuantity(element));
                if (elements[element] <= Convert.ToInt16(ElementQuantity(element)))
                {
                    availableStock.Add(element, elements[element]);
                }
                else
                {
                    if (Convert.ToInt16(ElementQuantity(element)) != 0)
                    {
                        availableStock.Add(element, Convert.ToInt16(ElementQuantity(element)));
                        notInStock.Add(element, elements[element] - Convert.ToInt16(ElementQuantity(element)));
                    }
                    else
                    {
                        notInStock.Add(element, elements[element]);
                    }
                }
            }
            elementsVsStock.Add(availableStock);
            elementsVsStock.Add(notInStock);
            return (elementsVsStock);
        }

        //returns blank array if login failed, returns clientId and name is successfull login
        public string[] Login(string Identifiant, string Pwd)
        {
            string[] clientId = new string[] { "", "" };
            this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
            try
            {
                connection.Open();
                MySqlCommand sqlCmd1 = new MySqlCommand("SELECT client_id, name, pwd, email from client", connection);
                MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                while (myReader.Read())
                {
                    if ((myReader.GetString(3).ToLower() == Identifiant.ToLower() || myReader.GetString(3) == Identifiant) && myReader.GetString(2) == Pwd)
                    {
                        clientId[0] = myReader.GetString(0);
                        clientId[1] = myReader.GetString(1);
                    }
                    else
                    { }
                }
                connection.Close();
            }
            catch
            {
                throw;
            }
            return (clientId);
        }

        //registers a new client in DB
        public string Register(string name, string email, string pwd)
        {
            string registred = "";
            this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
            try
            {
                connection.Open();
                MySqlCommand sqlCmd1 = new MySqlCommand("SELECT name, email from client", connection);
                MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                bool newClient = true;
                while (myReader.Read())
                {
                    //Console.WriteLine(myReader.Read());
                    if (myReader.GetString(0).ToLower() == name.ToLower() || myReader.GetString(1) == email)
                    {
                        newClient = false;
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

                if (newClient == true)
                {
                    // Opens SQL connection
                    this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
                    connection.Open();
                    // New SQL command. Depends on connection object
                    MySqlCommand cmd = this.connection.CreateCommand();
                    // SQL query
                    cmd.CommandText = "INSERT INTO client(name, email, pwd) VALUES (@name, @email, @pwd)";
                    // objects are assigned to their values
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@pwd", pwd);
                    // SQL command execution
                    cmd.ExecuteNonQuery();
                    MySqlCommand sqlCmd2 = new MySqlCommand("SELECT client_id from client WHERE email='" + email + "'", connection);
                    MySqlDataReader myReader2 = sqlCmd2.ExecuteReader();
                    while (myReader2.Read())
                    {
                        registred = myReader2.GetString(0);
                    }
                    this.connection.Close();
                }
            }
            catch (Exception ex)
            { }
            return (registred);
        }

        //adds a line in table sale and returns the generated order_id
        public string CreateCommand(Command command)
        {
            string id = "";
            this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
            try
            {
                connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "INSERT INTO sale(client_id, order_date, delivery_date, price, is_payed, is_delivered) VALUES (@client_id, @order_date, @delivery_date, @price, @is_payed, @is_delivered)";
                cmd.Parameters.AddWithValue("@client_id", command._clientId);
                cmd.Parameters.AddWithValue("@order_date", command._date);
                cmd.Parameters.AddWithValue("@delivery_date", command._deliveryDate);
                cmd.Parameters.AddWithValue("@price", command._price);
                cmd.Parameters.AddWithValue("@is_payed", command._isPayed.ToString());
                cmd.Parameters.AddWithValue("@is_delivered", command._isDelivered.ToString());
                cmd.ExecuteNonQuery();
                MySqlCommand sqlCmd2 = new MySqlCommand("SELECT order_id from sale WHERE client_id='" + command._clientId + "'", connection);
                MySqlDataReader myReader2 = sqlCmd2.ExecuteReader();
                while (myReader2.Read())
                {
                    id = myReader2.GetString(0);
                }
            }
            catch
            { }
            return id;

        }

        //creates a new line in table orderedpart
        public void CreateOrderedPart(Dictionary<string, int> elements, string order_id)
        {
            this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
            try
            {
                connection.Open();
                foreach (var element in elements)
                {
                    MySqlCommand cmd = this.connection.CreateCommand();
                    cmd.CommandText = "INSERT INTO orderedpart(order_id, code, mult) VALUES (@order_id, @code, @mult)";
                    cmd.Parameters.AddWithValue("@order_id", order_id);
                    cmd.Parameters.AddWithValue("@code", element.Key);
                    cmd.Parameters.AddWithValue("@mult", element.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            { }
            finally
            {
                connection.Close();
            }
        }

        //modifies the virtual and real stock of a part. Necessary when cabinet is sold
        public void ModifyStock(bool isDelivered, Dictionary<string, int> dicOfElements)
        {
            this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
            try
            {
                connection.Open();
                foreach (var element in dicOfElements)
                {
                    MySqlCommand cmd = this.connection.CreateCommand();
                    if (isDelivered == false)
                        cmd.CommandText = "UPDATE stock SET virtual_stock = virtual_stock +" + element.Value + " WHERE code ='" + element.Key + "'";
                    else
                        cmd.CommandText = "UPDATE stock SET real_stock = real_stock -" + element.Value + " WHERE code ='" + element.Key + "'";
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            { }
            finally
            {
                connection.Close();
            }
        }

        //returns code and multiplier of each part of a command.
        public Dictionary<string, int> FindPartsById(int id)
        {
            Dictionary<string, int> parts = new Dictionary<string, int>();
            this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
            try
            {
                connection.Open();
                MySqlCommand sqlCmd1 = new MySqlCommand("SELECT code,mult FROM orderedpart WHERE order_id='" + id + "'", connection);
                MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                string key = "";
                try
                {
                    while (myReader.Read())
                    {
                        int i;
                        for (i = 0; i < 2; i++)
                        {
                            if (i == 0) { key = myReader.GetString(i); }
                            else { parts.Add(key, Convert.ToInt16(myReader.GetString(i))); }
                        }
                    }
                }
                finally
                {
                    myReader.Close();
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            { }
            return (parts);
        }

        //returns the missing elements in stock table
        public List<string> VerifyStock()
        {
            List<string> missing = new List<string>();
            this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
            try
            {
                connection.Open();
                MySqlCommand sqlCmd1 = new MySqlCommand("SELECT real_stock,virtual_stock,code FROM stock", connection);
                MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                while (myReader.Read())
                {
                    int real_stock = Convert.ToInt32(myReader.GetString(0));
                    int virtual_stock = Convert.ToInt32(myReader.GetString(1));
                    if (real_stock - 2 * virtual_stock < 0)
                    {
                        missing.Add(myReader.GetString(2));
                    }
                }
            }
            catch
            { }
            return missing;
        }

        //updates the status of payed for given command
        public void Pay(int orderId)
        {
            this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
            connection.Open();
            MySqlCommand sqlCmd = new MySqlCommand("UPDATE sale SET is_payed = '" + "True" + "'  WHERE order_id= " + orderId, connection);
            sqlCmd.ExecuteNonQuery();
        }

        //updates real_stock and virtual_stock fields of stock 
        //table given the missing elements of a command
        public int Deliver(int orderId)
        {
            Dictionary<string, int> dicOfElements = FindPartsById(orderId);
            Dictionary<string, int> missingElements = ElementsInStock(dicOfElements)[1];
            if (missingElements.Count > 0)
                return -1;
            this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
            try
            {
                connection.Open();
                MySqlCommand sqlCmd = new MySqlCommand("UPDATE sale SET is_delivered = '" + "True" + "'  WHERE order_id= " + orderId, connection);
                sqlCmd.ExecuteNonQuery();
                foreach (var element in dicOfElements)
                {
                    MySqlCommand cmd = this.connection.CreateCommand();
                    cmd.CommandText = "UPDATE stock SET real_stock = real_stock -" + element.Value + " WHERE code ='" + element.Key + "'";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE stock SET virtual_stock = virtual_stock -" + element.Value + " WHERE code ='" + element.Key + "'";
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            { }
            finally
            {
                connection.Close();
            }
            return 1;
        }

        //returns every field from sale table for a given order_id
        public Dictionary<string, string> GetCommandInfo(int order_id)
        {
            Dictionary<string, string> cmdInfo = new Dictionary<string, string>();
            this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
            try
            {
                connection.Open();
                MySqlCommand sqlCmd1 = new MySqlCommand("SELECT * FROM sale WHERE order_id='" + order_id + "'", connection);
                MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                while (myReader.Read())
                {
                    cmdInfo.Add("order_id", myReader.GetString(0));
                    cmdInfo.Add("client_id", myReader.GetString(1));
                    cmdInfo.Add("order_date", myReader.GetString(2));
                    cmdInfo.Add("delivery_date", myReader.GetString(3));
                    cmdInfo.Add("price", myReader.GetString(4));
                    cmdInfo.Add("isPayed", myReader.GetString(5));
                    cmdInfo.Add("isDelivered", myReader.GetString(6));
                }
            }
            catch
            { }
            return cmdInfo;
        }

        //returns every field from client table for a given client_id
        public Dictionary<string, string> GetUserInfo(int clientId)
        {
            Dictionary<string, string> userInfo = new Dictionary<string, string>();
            this.connection = new MySqlConnection("server = localhost; uid = root; database = kitbox;");
            try
            {
                connection.Open();
                MySqlCommand sqlCmd1 = new MySqlCommand("SELECT * FROM client WHERE client_id='" + clientId + "'", connection);
                MySqlDataReader myReader = sqlCmd1.ExecuteReader();
                while (myReader.Read())
                {
                    userInfo.Add("client_id", myReader.GetString(0));
                    userInfo.Add("name", myReader.GetString(1));
                    userInfo.Add("pwd", myReader.GetString(2));
                    userInfo.Add("email", myReader.GetString(3));
                }
            }
            catch
            { }
            return userInfo;
        }
    }
}
