namespace gyumolcsok_forms
{
    partial class Form_Nyito
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.újGyümölcsHozzáadásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gyümölcsMódosításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gyümölcsTörléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.numericUpDown_egysegar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_mennyiseg = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_gyumolcs = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_egysegar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mennyiseg)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újGyümölcsHozzáadásaToolStripMenuItem,
            this.gyümölcsMódosításaToolStripMenuItem,
            this.gyümölcsTörléseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // újGyümölcsHozzáadásaToolStripMenuItem
            // 
            this.újGyümölcsHozzáadásaToolStripMenuItem.Name = "újGyümölcsHozzáadásaToolStripMenuItem";
            this.újGyümölcsHozzáadásaToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.újGyümölcsHozzáadásaToolStripMenuItem.Text = "Új gyümölcs hozzáadása";
            this.újGyümölcsHozzáadásaToolStripMenuItem.Click += new System.EventHandler(this.újGyümölcsHozzáadásaToolStripMenuItem_Click);
            // 
            // gyümölcsMódosításaToolStripMenuItem
            // 
            this.gyümölcsMódosításaToolStripMenuItem.Name = "gyümölcsMódosításaToolStripMenuItem";
            this.gyümölcsMódosításaToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.gyümölcsMódosításaToolStripMenuItem.Text = "Gyümölcs módosítása";
            this.gyümölcsMódosításaToolStripMenuItem.Click += new System.EventHandler(this.gyümölcsMódosításaToolStripMenuItem_Click);
            // 
            // gyümölcsTörléseToolStripMenuItem
            // 
            this.gyümölcsTörléseToolStripMenuItem.Name = "gyümölcsTörléseToolStripMenuItem";
            this.gyümölcsTörléseToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.gyümölcsTörléseToolStripMenuItem.Text = "Gyümölcs törlése";
            this.gyümölcsTörléseToolStripMenuItem.Click += new System.EventHandler(this.gyümölcsTörléseToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Egységár:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mennyiség:";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(170, 116);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(66, 20);
            this.textBox_id.TabIndex = 6;
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(170, 161);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(125, 20);
            this.textBox_nev.TabIndex = 7;
            // 
            // numericUpDown_egysegar
            // 
            this.numericUpDown_egysegar.DecimalPlaces = 2;
            this.numericUpDown_egysegar.Location = new System.Drawing.Point(170, 206);
            this.numericUpDown_egysegar.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_egysegar.Name = "numericUpDown_egysegar";
            this.numericUpDown_egysegar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown_egysegar.Size = new System.Drawing.Size(89, 20);
            this.numericUpDown_egysegar.TabIndex = 8;
            this.numericUpDown_egysegar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown_mennyiseg
            // 
            this.numericUpDown_mennyiseg.Location = new System.Drawing.Point(170, 250);
            this.numericUpDown_mennyiseg.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.numericUpDown_mennyiseg.Name = "numericUpDown_mennyiseg";
            this.numericUpDown_mennyiseg.Size = new System.Drawing.Size(89, 20);
            this.numericUpDown_mennyiseg.TabIndex = 9;
            this.numericUpDown_mennyiseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(196, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gyümölcsök nyilvántartása";
            // 
            // listBox_gyumolcs
            // 
            this.listBox_gyumolcs.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox_gyumolcs.FormattingEnabled = true;
            this.listBox_gyumolcs.Location = new System.Drawing.Point(546, 24);
            this.listBox_gyumolcs.Name = "listBox_gyumolcs";
            this.listBox_gyumolcs.Size = new System.Drawing.Size(138, 288);
            this.listBox_gyumolcs.TabIndex = 11;
            this.listBox_gyumolcs.SelectedIndexChanged += new System.EventHandler(this.listBox_gyumolcs_SelectedIndexChanged);
            // 
            // Form_Nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 312);
            this.Controls.Add(this.listBox_gyumolcs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_mennyiseg);
            this.Controls.Add(this.numericUpDown_egysegar);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Nyito";
            this.Text = "Nyitó Form";
            this.Load += new System.EventHandler(this.Form_Nyito_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_egysegar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mennyiseg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem újGyümölcsHozzáadásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gyümölcsMódosításaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gyümölcsTörléseToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_id;
        public System.Windows.Forms.TextBox textBox_nev;
        public System.Windows.Forms.NumericUpDown numericUpDown_egysegar;
        public System.Windows.Forms.NumericUpDown numericUpDown_mennyiseg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_gyumolcs;
    }
}

