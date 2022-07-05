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
                    // d.Type = oReader["TYPE"].ToString();
                    d.Name = oReader["NAME"].ToString();
                    Animals.Add(d);
                }

                
            }
            dbIndex = 0;
            connection.Close();
            return Animals;
        }

        public Animal GetAnimal(string name)
        {
            connection.Open();

            Animal returnValue = null;
            string com = string.Format("SELECT * FROM STORAGE WHERE NAME = '{0}'",name);
            command = new SqlCommand(com, connection);
            using (SqlDataReader oReader = command.ExecuteReader())
            {
                while (oReader.Read())
                {
                    if (oReader["TYPE"].ToString() == "cat")
                    {
                        returnValue = new Cat();
                        returnValue.Name = oReader["NAME"].ToString();
                    }
                    else if(oReader["TYPE"].ToString() == "dog")
                    {
                        returnValue = new Dog();
                        returnValue.Name = oReader["NAME"].ToString();
                    }
                }


            }
            connection.Close();
            return returnValue;
        }

        public List<Object> GetAnimals(Animal.AnimalType _type)
        {
            string com;
            connection.Open();
            List<Object> Animals = new List<Object>();


            switch (_type)
            {
                case Animal.AnimalType.Dog:
                    com = "SELECT * FROM STORAGE WHERE TYPE = 'dog'";
                    command = new SqlCommand(com, connection);
                    using (SqlDataReader oReader = command.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            Dog d = new Dog();
                            // d.Type = oReader["TYPE"].ToString();
                            d._AnimalType = Animal.AnimalType.Dog;
                            d.Name = oReader["NAME"].ToString();
                            Animals.Add(d);
                        }


                    }
                    return Animals;
                    break;
                case Animal.AnimalType.Cat:
                    com = "SELECT * FROM STORAGE WHERE TYPE = 'cat'";
                    command = new SqlCommand(com, connection);
                    using (SqlDataReader oReader = command.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            Cat c = new Cat();
                            // d.Type = oReader["TYPE"].ToString();
                            //c._AnimalType = Animal.AnimalType.Dog;
                            c.Name = oReader["NAME"].ToString();
                            Animals.Add(c);
                        }


                    }
                    break;
                case Animal.AnimalType.Bird:
                    com = "SELECT * FROM STORAGE WHERE TYPE = 'bird'";
                    break;
                    default:
                    //keno
                    break;
            }

            return null;

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
