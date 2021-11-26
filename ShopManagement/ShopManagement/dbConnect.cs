using System;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ShopManagement
{
    public class dbConnect
    {
        private MySqlConnection connection;

        public dbConnect(string str)
        {
            if (str != "")
            {
                InitializeDatabase(str);
            }
        }

        private void InitializeDatabase(string str)
        {
            try
            {
                connection = new MySqlConnection(str);
            } catch (MySqlException e)
            {
                MessageBox.Show("Hiba: "+e);
            }
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        // SELECT
        public List<Dictionary<String, Object>> Select(string query)
        {
            List<Dictionary<String, Object>> result = new List<Dictionary<String, Object>>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Dictionary<String, Object> dict = new Dictionary<String, Object>();

                    for (int i = 0; i <= (reader.FieldCount - 1); i++)
                    {
                        dict.Add(reader.GetName(i), reader[i]);
                    }

                    result.Add(dict);
                }

                this.CloseConnection();
            }

            return result;
        }

        // INSERT
        public int Insert(string query)
        {
            int lastID = -1;

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    lastID = (int)Math.Min(Int32.MaxValue, cmd.LastInsertedId);

                } catch (Exception)
                {
                    throw;
                }

                this.CloseConnection();
            }

            return lastID;
        }

        //DELETE
        public bool Delete(string query)
        {
            bool state = false;

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    state = true;
                } catch (Exception)
                {
                    throw;
                }

                this.CloseConnection();
            }

            return state;
        }

        //UPDATE
        public bool Update(string query)
        {
            bool state = false;

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    state = true;
                } catch (Exception)
                {
                    throw;
                }

                this.CloseConnection();
            }

            return state;
        }
    }
}
