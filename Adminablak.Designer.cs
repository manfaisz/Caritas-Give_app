using System;

namespace Caritas_Giveapp
{
    partial class Adminablak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminablak));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adományKíadásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kliensekFelvételetörléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rászolonakKözvetlenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lekérdezésekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhaszálókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újFelhasználóRögzítéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(145, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adomány nyilvántartó - Admin felület";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adományKíadásToolStripMenuItem,
            this.lekérdezésekToolStripMenuItem,
            this.felhaszálókToolStripMenuItem,
            this.névjegyToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(83, 70);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(407, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adományKíadásToolStripMenuItem
            // 
            this.adományKíadásToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kliensekFelvételetörléseToolStripMenuItem,
            this.rászolonakKözvetlenToolStripMenuItem});
            this.adományKíadásToolStripMenuItem.Name = "adományKíadásToolStripMenuItem";
            this.adományKíadásToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.adományKíadásToolStripMenuItem.Text = "Adomány kíadás";
            // 
            // kliensekFelvételetörléseToolStripMenuItem
            // 
            this.kliensekFelvételetörléseToolStripMenuItem.Name = "kliensekFelvételetörléseToolStripMenuItem";
            this.kliensekFelvételetörléseToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.kliensekFelvételetörléseToolStripMenuItem.Text = "Kliensek felvétele";
            this.kliensekFelvételetörléseToolStripMenuItem.Click += new System.EventHandler(this.kliensekFelvételetörléseToolStripMenuItem_Click);
            // 
            // rászolonakKözvetlenToolStripMenuItem
            // 
            this.rászolonakKözvetlenToolStripMenuItem.Name = "rászolonakKözvetlenToolStripMenuItem";
            this.rászolonakKözvetlenToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.rászolonakKözvetlenToolStripMenuItem.Text = "Adomány kiadás kliensnek";
            this.rászolonakKözvetlenToolStripMenuItem.Click += new System.EventHandler(this.rászolonakKözvetlenToolStripMenuItem_Click);
            // 
            // lekérdezésekToolStripMenuItem
            // 
            this.lekérdezésekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.haviToolStripMenuItem});
            this.lekérdezésekToolStripMenuItem.Name = "lekérdezésekToolStripMenuItem";
            this.lekérdezésekToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.lekérdezésekToolStripMenuItem.Text = "Lekérdezések";
            // 
            // haviToolStripMenuItem
            // 
            this.haviToolStripMenuItem.DoubleClickEnabled = true;
            this.haviToolStripMenuItem.Name = "haviToolStripMenuItem";
            this.haviToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.haviToolStripMenuItem.Text = "Kiadott adományok";
            this.haviToolStripMenuItem.Click += new System.EventHandler(this.haviToolStripMenuItem_Click);
            // 
            // felhaszálókToolStripMenuItem
            // 
            this.felhaszálókToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újFelhasználóRögzítéseToolStripMenuItem});
            this.felhaszálókToolStripMenuItem.Name = "felhaszálókToolStripMenuItem";
            this.felhaszálókToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.felhaszálókToolStripMenuItem.Text = "Felhasználók";
            // 
            // újFelhasználóRögzítéseToolStripMenuItem
            // 
            this.újFelhasználóRögzítéseToolStripMenuItem.Name = "újFelhasználóRögzítéseToolStripMenuItem";
            this.újFelhasználóRögzítéseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.újFelhasználóRögzítéseToolStripMenuItem.Text = "Felhasználók felvétele";
            this.újFelhasználóRögzítéseToolStripMenuItem.Click += new System.EventHandler(this.újFelhasználóRögzítéseToolStripMenuItem_Click);
            // 
            // névjegyToolStripMenuItem
            // 
            this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.névjegyToolStripMenuItem.Text = "Névjegy";
            this.névjegyToolStripMenuItem.Click += new System.EventHandler(this.névjegyToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click_1);
            // 
            // Adminablak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(577, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Adminablak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caritas Give_app";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nevjegy ablak = new Nevjegy();                          //névjegy ablak létrehozása
            ablak.Show();                                           //névjegy ablak megjelenítése
        }

        private void haviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lekerdezes ablak1 = new Lekerdezes();                          //névjegy ablak létrehozása
            ablak1.Show();                                           //névjegy ablak megjelenít
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adományKíadásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rászolonakKözvetlenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhaszálókToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újFelhasználóRögzítéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lekérdezésekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kliensekFelvételetörléseToolStripMenuItem;
    }
}

