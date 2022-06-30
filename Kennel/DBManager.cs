using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kennel
{
    public class DBManager
    {
        SqlConnection connection;
        SqlCommand command;
        int dbIndex = 0;
        int maxItems = 0;
        public void Connect()
        {
            string connectionString = Properties.Settings.Default.KENELDBConnectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();
            Test();
        }

        void Disconnect()
        {
            connection.Close();
        }

        void Test()
        {
            string com = "SELECT COUNT(*) FROM STORAGE";
            command = new SqlCommand(com, connection);
            maxItems = (int)command.ExecuteScalar();
            connection.Close();
        }

        public void StoreData(Animal animal)
        {
            try
            {
                string com = string.Format("INSERT INTO STORAGE (TYPE,NAME) VALUES ('{0}','{1}')", typeof(Animal).ToString(), animal.Name);
                command = new SqlCommand(com, connection);
                command.ExecuteScalar();
            }
            catch
            {
                connection.Open();
                string com = string.Format("INSERT INTO STORAGE (TYPE,NAME) VALUES ('{0}','{1}')", "dog", animal.Name);
                command = new SqlCommand(com, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<Dog> GetAnimalsDog()
        {
            List<Dog> Animals = new List<Dog>();
            connection.Open();
            //for (dbIndex = 0; dbIndex < maxItems; dbIndex++)
            //{
            string com = "SELECT * FROM STORAGE WHERE TYPE = 'dog'";
            command = new SqlCommand(com, connection);
            //    Animals.Add(command.ExecuteScalar());
            //}

            using (SqlDataReader oReader = command.ExecuteReader())
            {
                while (oReader.Read())
                {
                    Dog d = new Dog();
                     d.Type = oReader["TYPE"].ToString();
                    d.Name = oReader["NAME"].ToString();
                    Animals.Add(d);
                }

                
            }


            for (int i = 0; i < Animals.Count; i++)
            {
                Console.WriteLine(Animals[i].Name);
            }
            dbIndex = 0;
            connection.Close();
            return Animals;
        }

        public void DeleteAnimal(string name)
        {
            connection.Open();
            string com = string.Format("DELETE FROM STORAGE WHERE NAME = '{0}'", name);
            command = new SqlCommand(com, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
