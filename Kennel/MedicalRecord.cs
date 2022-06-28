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
    public partial class MedicalRecord : Form
    {
        FileManager fm;
        public MedicalRecord()
        {
            InitializeComponent();
            StartUp();
        }

        void StartUp()
        {
            fm = new FileManager();
            FillCheckBox();
        }

        void FillCheckBox()
        {
            string strings = fm.Read();
            for(int i = 0;i < strings.Length;i++)
            {
                cb_Diseases.Items.Add(strings[i]);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            fm.Write("Test2");
            this.Hide();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (btn_edit.Text == "Edit")
            {
                textBox2.Visible = true;
                btn_edit.Text = "Save";
            }
            else
            {
                textBox2.Visible = false;
                btn_edit.Text = "Edit";
                if(textBox2.Text != "" || textBox2.Text != string.Empty)
                {
                    fm.Write(textBox2.Text);
                    cb_Diseases.Items.Add(textBox2.Text);
                }
            }
        }
    }
}
