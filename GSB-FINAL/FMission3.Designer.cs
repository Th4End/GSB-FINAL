namespace GSB_FINAL
{
    partial class FMission3
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
            this.components = new System.ComponentModel.Container();
            this.dgvfiches = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bsFiches = new System.Windows.Forms.BindingSource(this.components);
            this.aLaSmeneProDataSet = new GSB_FINAL.ALaSmeneProDataSet();
            this.PanelFiltre = new System.Windows.Forms.Panel();
            this.CheckFiltre = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfiches)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLaSmeneProDataSet)).BeginInit();
            this.PanelFiltre.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvfiches
            // 
            this.dgvfiches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfiches.Location = new System.Drawing.Point(12, 95);
            this.dgvfiches.Name = "dgvfiches";
            this.dgvfiches.Size = new System.Drawing.Size(636, 282);
            this.dgvfiches.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(358, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Création";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bsFiches
            // 
            this.bsFiches.DataSource = this.aLaSmeneProDataSet;
            this.bsFiches.Position = 0;
            // 
            // aLaSmeneProDataSet
            // 
            this.aLaSmeneProDataSet.DataSetName = "ALaSmeneProDataSet";
            this.aLaSmeneProDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PanelFiltre
            // 
            this.PanelFiltre.Controls.Add(this.comboBox1);
            this.PanelFiltre.Controls.Add(this.textBox8);
            this.PanelFiltre.Controls.Add(this.textBox7);
            this.PanelFiltre.Controls.Add(this.textBox6);
            this.PanelFiltre.Controls.Add(this.textBox5);
            this.PanelFiltre.Controls.Add(this.textBox4);
            this.PanelFiltre.Controls.Add(this.textBox3);
            this.PanelFiltre.Controls.Add(this.textBox1);
            this.PanelFiltre.Location = new System.Drawing.Point(674, 95);
            this.PanelFiltre.Name = "PanelFiltre";
            this.PanelFiltre.Size = new System.Drawing.Size(268, 177);
            this.PanelFiltre.TabIndex = 7;
            this.PanelFiltre.Visible = false;
            // 
            // CheckFiltre
            // 
            this.CheckFiltre.AutoSize = true;
            this.CheckFiltre.Location = new System.Drawing.Point(683, 61);
            this.CheckFiltre.Name = "CheckFiltre";
            this.CheckFiltre.Size = new System.Drawing.Size(66, 17);
            this.CheckFiltre.TabIndex = 8;
            this.CheckFiltre.Text = "FILTRE ";
            this.CheckFiltre.UseVisualStyleBackColor = true;
            this.CheckFiltre.CheckedChanged += new System.EventHandler(this.CheckFiltre_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(196, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(72, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 65);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(69, 20);
            this.textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(121, 24);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(69, 20);
            this.textBox5.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(9, 24);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 4;
            this.textBox6.Text = "Mois/Année :";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(9, 65);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 5;
            this.textBox7.Text = "Période :";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(9, 118);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 6;
            this.textBox8.Text = "État :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Remboursée",
            "Saisie clôturée",
            "Fiche créée, saisie en cours",
            "Validée et mise en paiement"});
            this.comboBox1.Location = new System.Drawing.Point(134, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // FMission3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 532);
            this.Controls.Add(this.CheckFiltre);
            this.Controls.Add(this.PanelFiltre);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dgvfiches);
            this.Name = "FMission3";
            this.Text = "FMission3";
            this.Load += new System.EventHandler(this.FMission3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfiches)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLaSmeneProDataSet)).EndInit();
            this.PanelFiltre.ResumeLayout(false);
            this.PanelFiltre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvfiches;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource bsFiches;
        private ALaSmeneProDataSet aLaSmeneProDataSet;
        private System.Windows.Forms.Panel PanelFiltre;
        private System.Windows.Forms.CheckBox CheckFiltre;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox8;
    }
}