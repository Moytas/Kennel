using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kennel
{
    public partial class AnimalDetails : Form
    {
        private Dog _dog;
        public AnimalDetails()
        {
            InitializeComponent();
            StartUp();
        }

        void StartUp()
        {
            tb_DogAge.Enabled = false;
            tb_DogName.Enabled = false;
        }

        private void btn_DogEdit_Click(object sender, EventArgs e)
        {
            tb_DogAge.Enabled = true;
            tb_DogName.Enabled = true;
        }

        public void PassDog(Dog dog)
        {
                _dog = dog;
                tb_DogName.Text = _dog.Name;
        }

        public void PassAnimal(Animal animal)
        {
            if(animal.GetType() == typeof(Dog))
            {
                tabControl1.SelectedIndex = 0;
            }
            else
            {
                tabControl1.SelectedIndex = 1;
            }
        }

        public void PassAnimal(string name)
        {

        }

        public void PassAnimal(object animal,int age)
        { }

        public void PassAnimal(object animal,string name, int age)
        {

        }

        private void AnimalDetails_Load(object sender, EventArgs e)
        {

        }

        public void Closing()
        {

        }

        private void AnimalDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
