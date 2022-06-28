using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//C:\Users\Datalabs Teacher\source\repos\Kennel

namespace Kennel
{
    public partial class Form1 : Form
    {
        List<Cat> CatsList = new List<Cat>();
        List<Dog> DogsList = new List<Dog>();

        Dictionary<string,string> AnimalDictionary = new Dictionary<string,string>();

        public Form1()
        {
            InitializeComponent();
            Cat _cat = new Cat("A");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_name.Text != "")
            {
                //if(cb_type.SelectedIndex == 1)
                //{
                //    Dog newDog = new Dog();
                //    newDog.Name = tb_name.Text;
                //    DogsList.Add(newDog);
                //}
                //else if(cb_type.SelectedIndex == 0)
                //{
                //    Cat newCat = new Cat();
                //    newCat.Name = tb_name.Text;
                //    CatsList.Add(newCat);
                //}
                //else if(cb_type.SelectedIndex == 2)
                //{

                //}
                //else
                //{

                //}

                switch(cb_type.SelectedIndex)
                {
                    case 0:
                        Cat newCat = new Cat();
                        newCat.Name = tb_name.Text;
                        CatsList.Add(newCat);
                        AnimalDictionary.Add(newCat.Name, "cat");
                        break;
                        case 1:
                        Dog newDog = new Dog("mpla");
                        newDog.Name = tb_name.Text;
                        DogsList.Add(newDog);

                        AnimalDictionary.Add(newDog.Name, "dog");
                        break;
                        default:
                        break;

                }

                tb_name.Text = "";
                CreateList();
            }
        }

        private void CreateList()
        {
            lb_AnimalsStored.Items.Clear();
            for(int i = 0; i < CatsList.Count; i++)
            {
                lb_AnimalsStored.Items.Add(CatsList[i].Name);
            }

            for(int i = 0; i < DogsList.Count; i++)
            {
                lb_AnimalsStored.Items.Add(DogsList[i].Name);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string name = "";
            name = lb_AnimalsStored.Items[lb_AnimalsStored.SelectedIndex].ToString();

            for (int i = 0; i < DogsList.Count; i++)
            {
                if (DogsList[i].Name == name)
                {
                    DogsList.RemoveAt(i);
                }
            }

            for (int i = 0; i < CatsList.Count; i++)
            {
                if (CatsList[i].Name == name)
                {
                    CatsList.RemoveAt(i);
                }
            }
            CreateList();
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            AnimalDetails dogDetails = new AnimalDetails();
           
            if(FindAnimal(lb_AnimalsStored.SelectedIndex) == "dog")
            {
                for(int i = 0; i < DogsList.Count; i++)
                {
                    if(DogsList[i].Name == lb_AnimalsStored.Text)
                    {
                        Dog newDog = DogsList[i];
                        dogDetails.PassAnimal(newDog);
                    }
                }

            }
            else
            {
                for (int i = 0; i < CatsList.Count; i++)
                {
                    if (CatsList[i].Name == lb_AnimalsStored.Text)
                    {
                        Cat newCat = CatsList[i];
                        dogDetails.PassAnimal(newCat);

                    }
                }
            }
            dogDetails.Show();

        }

        private string FindAnimal(int index)
        {
            string type = "";
            try
            {
                string name = lb_AnimalsStored.Items[index].ToString();
                AnimalDictionary.TryGetValue(name, out type);
            }
            catch
            {
                if(index == -1)
                {
                    index = 0;
                   // lb_AnimalsStored.SelectedIndex = 1;
                    string name = lb_AnimalsStored.Items[index].ToString();
                    AnimalDictionary.TryGetValue(name, out type);
                }
            }
            return type;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicalRecord form2 = new MedicalRecord();
            form2.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MedicalRecord form2 = new MedicalRecord();
            form2.Show();
        }

        private void medicalPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicalRecord form2 = new MedicalRecord();
            form2.Show();
        }

        private void showListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
