using System;

namespace Caritas_Giveapp
{
    partial class Adomanyok
    {
     
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.ITextBox = new System.Windows.Forms.TextBox();
            this.RhTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Abt = new System.Windows.Forms.Button();
            this.Nbt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AzstextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EltextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Mentesbt = new System.Windows.Forms.Button();
            this.Listbutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név alapján";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Azonosító";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ruha adomány (Kg)";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(161, 20);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 5;
            // 
            // ITextBox
            // 
            this.ITextBox.Location = new System.Drawing.Point(161, 49);
            this.ITextBox.Name = "ITextBox";
            this.ITextBox.Size = new System.Drawing.Size(100, 20);
            this.ITextBox.TabIndex = 8;
            // 
            // RhTextBox
            // 
            this.RhTextBox.Location = new System.Drawing.Point(161, 80);
            this.RhTextBox.Name = "RhTextBox";
            this.RhTextBox.Size = new System.Drawing.Size(100, 20);
            this.RhTextBox.TabIndex = 9;
            this.RhTextBox.TextChanged += new System.EventHandler(this.AdreesTextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(749, 405);
            this.dataGridView1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Abt);
            this.groupBox1.Controls.Add(this.Nbt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AzstextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IdTextBox);
            this.groupBox1.Location = new System.Drawing.Point(34, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 151);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kliesek keresése";
            // 
            // Abt
            // 
            this.Abt.Location = new System.Drawing.Point(161, 104);
            this.Abt.Name = "Abt";
            this.Abt.Size = new System.Drawing.Size(99, 23);
            this.Abt.TabIndex = 18;
            this.Abt.Text = "Keresés";
            this.Abt.UseVisualStyleBackColor = true;
            this.Abt.Click += new System.EventHandler(this.Abt_Click);
            // 
            // Nbt
            // 
            this.Nbt.Location = new System.Drawing.Point(161, 46);
            this.Nbt.Name = "Nbt";
            this.Nbt.Size = new System.Drawing.Size(99, 23);
            this.Nbt.TabIndex = 17;
            this.Nbt.Text = "Keresés";
            this.Nbt.UseVisualStyleBackColor = true;
            this.Nbt.Click += new System.EventHandler(this.Nbt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Azonosító alapján";
            // 
            // AzstextBox
            // 
            this.AzstextBox.Location = new System.Drawing.Point(161, 78);
            this.AzstextBox.Name = "AzstextBox";
            this.AzstextBox.Size = new System.Drawing.Size(100, 20);
            this.AzstextBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Élelmiszer adomány  (Kg)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // EltextBox
            // 
            this.EltextBox.Location = new System.Drawing.Point(161, 108);
            this.EltextBox.Name = "EltextBox";
            this.EltextBox.Size = new System.Drawing.Size(100, 20);
            this.EltextBox.TabIndex = 11;
            this.EltextBox.TextChanged += new System.EventHandler(this.TeltextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Violet;
            this.label6.Location = new System.Drawing.Point(51, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "Adomány kíadás";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Violet;
            this.label7.Location = new System.Drawing.Point(629, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 31);
            this.label7.TabIndex = 18;
            this.label7.Text = "Adomány listázás";
            // 
            // Mentesbt
            // 
            this.Mentesbt.Location = new System.Drawing.Point(161, 137);
            this.Mentesbt.Name = "Mentesbt";
            this.Mentesbt.Size = new System.Drawing.Size(100, 23);
            this.Mentesbt.TabIndex = 10;
            this.Mentesbt.Text = "Mentés";
            this.Mentesbt.UseVisualStyleBackColor = true;
            this.Mentesbt.Click += new System.EventHandler(this.Mentesbt_Click);
            // 
            // Listbutton
            // 
            this.Listbutton.Location = new System.Drawing.Point(161, 175);
            this.Listbutton.Name = "Listbutton";
            this.Listbutton.Size = new System.Drawing.Size(99, 23);
            this.Listbutton.TabIndex = 15;
            this.Listbutton.Text = "Listázás";
            this.Listbutton.UseVisualStyleBackColor = true;
            this.Listbutton.Click += new System.EventHandler(this.Listbutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.ITextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.EltextBox);
            this.groupBox2.Controls.Add(this.Listbutton);
            this.groupBox2.Controls.Add(this.Mentesbt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.RhTextBox);
            this.groupBox2.Location = new System.Drawing.Point(34, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 206);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adomány rőgzítés";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Kiadott adományok (összes)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Adomány";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // Adomanyok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1081, 464);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Adomanyok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Give_app";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox ITextBox;
        private System.Windows.Forms.TextBox RhTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Mentesbt;
        private System.Windows.Forms.Button Listbutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox EltextBox;


        private void TeltextBox_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void AdreesTextBox_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void label8_Click(object sender, System.EventArgs e)
        {

        }

    
 

        private void Form3_Load(object sender, System.EventArgs e)
        {

        }
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AzstextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Abt;
        private System.Windows.Forms.Button Nbt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}