namespace GSB_FINAL
{
    partial class Fcreationvisiteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fcreationvisiteur));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboregions = new System.Windows.Forms.ComboBox();
            this.textville = new System.Windows.Forms.TextBox();
            this.textnom = new System.Windows.Forms.TextBox();
            this.textdateembauche = new System.Windows.Forms.TextBox();
            this.textrue = new System.Windows.Forms.TextBox();
            this.textprenom = new System.Windows.Forms.TextBox();
            this.textcp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bsregions = new System.Windows.Forms.BindingSource(this.components);
            this.bssecteurs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsregions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bssecteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.5F);
            this.textBox1.Location = new System.Drawing.Point(48, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(664, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Creation du compte";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(180, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(180, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PRENOM :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(180, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "RUE :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(180, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DATE EMBAUCHE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(177, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "VILLE :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(177, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "CP :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(554, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "REGION :";
            // 
            // cboregions
            // 
            this.cboregions.FormattingEnabled = true;
            this.cboregions.Location = new System.Drawing.Point(615, 170);
            this.cboregions.Name = "cboregions";
            this.cboregions.Size = new System.Drawing.Size(121, 21);
            this.cboregions.TabIndex = 8;
            // 
            // textville
            // 
            this.textville.Location = new System.Drawing.Point(225, 298);
            this.textville.Name = "textville";
            this.textville.Size = new System.Drawing.Size(100, 20);
            this.textville.TabIndex = 9;
            this.textville.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textnom
            // 
            this.textnom.Location = new System.Drawing.Point(230, 131);
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(100, 20);
            this.textnom.TabIndex = 10;
            // 
            // textdateembauche
            // 
            this.textdateembauche.Location = new System.Drawing.Point(291, 256);
            this.textdateembauche.Name = "textdateembauche";
            this.textdateembauche.Size = new System.Drawing.Size(100, 20);
            this.textdateembauche.TabIndex = 11;
            // 
            // textrue
            // 
            this.textrue.Location = new System.Drawing.Point(222, 214);
            this.textrue.Name = "textrue";
            this.textrue.Size = new System.Drawing.Size(100, 20);
            this.textrue.TabIndex = 12;
            // 
            // textprenom
            // 
            this.textprenom.Location = new System.Drawing.Point(246, 171);
            this.textprenom.Name = "textprenom";
            this.textprenom.Size = new System.Drawing.Size(100, 20);
            this.textprenom.TabIndex = 13;
            // 
            // textcp
            // 
            this.textcp.Location = new System.Drawing.Point(210, 350);
            this.textcp.Name = "textcp";
            this.textcp.Size = new System.Drawing.Size(100, 20);
            this.textcp.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fcreationvisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textcp);
            this.Controls.Add(this.textprenom);
            this.Controls.Add(this.textrue);
            this.Controls.Add(this.textdateembauche);
            this.Controls.Add(this.textnom);
            this.Controls.Add(this.textville);
            this.Controls.Add(this.cboregions);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Fcreationvisiteur";
            this.Text = "Fcreationvisiteur";
            this.Load += new System.EventHandler(this.Fcreationvisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsregions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bssecteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboregions;
        private System.Windows.Forms.TextBox textville;
        private System.Windows.Forms.TextBox textnom;
        private System.Windows.Forms.TextBox textdateembauche;
        private System.Windows.Forms.TextBox textrue;
        private System.Windows.Forms.TextBox textprenom;
        private System.Windows.Forms.TextBox textcp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bsregions;
        private System.Windows.Forms.BindingSource bssecteurs;
    }
}