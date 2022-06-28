using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Kennel
{
    class FileManager
    {
        string _path;
        string _fileName;

        public FileManager()
        {
             _path = Path.GetDirectoryName(Application.ExecutablePath);
        }

        public FileManager(string newPath)
        {
            _path = newPath;
        }

        public string Read()
        {
            //string settings = "";
            //try
            //{
            if (_fileName == null || _fileName == String.Empty)
            {
                _fileName = _path + @"\Settings.json";
            }
            //     settings = File.ReadAllText(_fileName);

            //    DogDisease diseases = JsonSerializer.Deserialize<DogDisease>()

            //}
            //catch
            //{

            //}
            //return settings;
            // read file into a string and deserialize JSON to a type
            DogDisease _dd = JsonConvert.DeserializeObject<DogDisease>(File.ReadAllText(_fileName));

            // deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(_fileName))
            {
                JsonSerializer serializer = new JsonSerializer();
                DogDisease movie2 = (DogDisease)serializer.Deserialize(file, typeof(DogDisease));
                Console.WriteLine(movie2.Name);
            }
            return "";
        }

        public void Write(string textToWrite)
        {
            if (!File.Exists(_fileName))
            {
                if(_fileName == null)
                {
                    _fileName = _path + @"\Settings.json";
                    //textToWrite += @"\n";
                    string JsonText = string.Format( "'Name' : {0}", textToWrite);
                    string jsonString = JsonConvert.SerializeObject(JsonText);
                    File.WriteAllText(_fileName, jsonString);
                }
            }

            try
            {
                textToWrite += "\n";
                File.AppendAllText(_fileName, textToWrite);
                
            }
            catch
            {
                
            }
        }
    }
}
