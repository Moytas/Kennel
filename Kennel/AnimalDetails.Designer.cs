namespace Kennel
{
    partial class AnimalDetails
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
            this.tb_DogName = new System.Windows.Forms.TextBox();
            this.tb_DogAge = new System.Windows.Forms.TextBox();
            this.btn_DogEdit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_CatName = new System.Windows.Forms.TextBox();
            this.tb_CatAge = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_DogName
            // 
            this.tb_DogName.Location = new System.Drawing.Point(6, 21);
            this.tb_DogName.Name = "tb_DogName";
            this.tb_DogName.Size = new System.Drawing.Size(100, 20);
            this.tb_DogName.TabIndex = 0;
            this.tb_DogName.Text = "Name";
            // 
            // tb_DogAge
            // 
            this.tb_DogAge.Location = new System.Drawing.Point(6, 62);
            this.tb_DogAge.Name = "tb_DogAge";
            this.tb_DogAge.Size = new System.Drawing.Size(100, 20);
            this.tb_DogAge.TabIndex = 1;
            this.tb_DogAge.Text = "Age";
            // 
            // btn_DogEdit
            // 
            this.btn_DogEdit.Location = new System.Drawing.Point(147, 201);
            this.btn_DogEdit.Name = "btn_DogEdit";
            this.btn_DogEdit.Size = new System.Drawing.Size(75, 23);
            this.btn_DogEdit.TabIndex = 2;
            this.btn_DogEdit.Text = "Edit";
            this.btn_DogEdit.UseVisualStyleBackColor = true;
            this.btn_DogEdit.Click += new System.EventHandler(this.btn_DogEdit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 183);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb_DogName);
            this.tabPage1.Controls.Add(this.tb_DogAge);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(331, 157);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dogs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_CatName);
            this.tabPage2.Controls.Add(this.tb_CatAge);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(331, 157);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cats";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_CatName
            // 
            this.tb_CatName.Location = new System.Drawing.Point(25, 32);
            this.tb_CatName.Name = "tb_CatName";
            this.tb_CatName.Size = new System.Drawing.Size(100, 20);
            this.tb_CatName.TabIndex = 2;
            this.tb_CatName.Text = "Name";
            // 
            // tb_CatAge
            // 
            this.tb_CatAge.Location = new System.Drawing.Point(25, 73);
            this.tb_CatAge.Name = "tb_CatAge";
            this.tb_CatAge.Size = new System.Drawing.Size(100, 20);
            this.tb_CatAge.TabIndex = 3;
            this.tb_CatAge.Text = "Age";
            // 
            // AnimalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 236);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_DogEdit);
            this.Name = "AnimalDetails";
            this.Text = "Animal Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnimalDetails_FormClosing);
            this.Load += new System.EventHandler(this.AnimalDetails_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_DogName;
        private System.Windows.Forms.TextBox tb_DogAge;
        private System.Windows.Forms.Button btn_DogEdit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_CatName;
        private System.Windows.Forms.TextBox tb_CatAge;
    }
}