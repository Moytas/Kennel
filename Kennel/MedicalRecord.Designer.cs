namespace Kennel
{
    partial class MedicalRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_PetName = new System.Windows.Forms.Label();
            this.cb_Diseases = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_PetName
            // 
            this.lbl_PetName.AutoSize = true;
            this.lbl_PetName.Location = new System.Drawing.Point(76, 51);
            this.lbl_PetName.Name = "lbl_PetName";
            this.lbl_PetName.Size = new System.Drawing.Size(54, 13);
            this.lbl_PetName.TabIndex = 0;
            this.lbl_PetName.Text = "Pet Name";
            // 
            // cb_Diseases
            // 
            this.cb_Diseases.FormattingEnabled = true;
            this.cb_Diseases.Location = new System.Drawing.Point(319, 51);
            this.cb_Diseases.Name = "cb_Diseases";
            this.cb_Diseases.Size = new System.Drawing.Size(120, 94);
            this.cb_Diseases.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(479, 51);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(158, 99);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(75, 23);
            this.btn_Find.TabIndex = 4;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(181, 198);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(160, 23);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Save And Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(508, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Visible = false;
            // 
            // MedicalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 304);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cb_Diseases);
            this.Controls.Add(this.lbl_PetName);
            this.Name = "MedicalRecord";
            this.Text = "Medical Records";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PetName;
        private System.Windows.Forms.CheckedListBox cb_Diseases;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox textBox2;
    }
}