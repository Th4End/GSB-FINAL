namespace GSB_FINAL
{
    partial class FConsultermesinfos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConsultermesinfos));
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.textnom = new System.Windows.Forms.TextBox();
            this.textprenom = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.prénom = new System.Windows.Forms.TextBox();
            this.dgvconsultermesinfos = new System.Windows.Forms.DataGridView();
            this.textrue = new System.Windows.Forms.TextBox();
            this.textcodepostale = new System.Windows.Forms.TextBox();
            this.textville = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.labelinfos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultermesinfos)).BeginInit();
            this.SuspendLayout();
            // 
            // bsVisiteur
            // 
            this.bsVisiteur.CurrentChanged += new System.EventHandler(this.bsConsultermesinfos_CurrentChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Annuler
            // 
            this.Annuler.Location = new System.Drawing.Point(163, 398);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(103, 23);
            this.Annuler.TabIndex = 1;
            this.Annuler.Text = "Modifier";
            this.Annuler.UseVisualStyleBackColor = true;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // textnom
            // 
            this.textnom.Location = new System.Drawing.Point(244, 134);
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(100, 20);
            this.textnom.TabIndex = 3;
            this.textnom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textprenom
            // 
            this.textprenom.Location = new System.Drawing.Point(244, 187);
            this.textprenom.Name = "textprenom";
            this.textprenom.Size = new System.Drawing.Size(100, 20);
            this.textprenom.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(163, 134);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(51, 13);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "Nom :";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // prénom
            // 
            this.prénom.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.prénom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prénom.Location = new System.Drawing.Point(157, 187);
            this.prénom.Name = "prénom";
            this.prénom.Size = new System.Drawing.Size(52, 13);
            this.prénom.TabIndex = 11;
            this.prénom.Text = "prénom : ";
            this.prénom.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // dgvconsultermesinfos
            // 
            this.dgvconsultermesinfos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsultermesinfos.Location = new System.Drawing.Point(149, 69);
            this.dgvconsultermesinfos.Name = "dgvconsultermesinfos";
            this.dgvconsultermesinfos.Size = new System.Drawing.Size(491, 279);
            this.dgvconsultermesinfos.TabIndex = 2;
            this.dgvconsultermesinfos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvconsultermesinfos_CellContentClick);
            // 
            // textrue
            // 
            this.textrue.Location = new System.Drawing.Point(465, 134);
            this.textrue.Name = "textrue";
            this.textrue.Size = new System.Drawing.Size(100, 20);
            this.textrue.TabIndex = 12;
            // 
            // textcodepostale
            // 
            this.textcodepostale.Location = new System.Drawing.Point(465, 187);
            this.textcodepostale.Name = "textcodepostale";
            this.textcodepostale.Size = new System.Drawing.Size(100, 20);
            this.textcodepostale.TabIndex = 13;
            // 
            // textville
            // 
            this.textville.Location = new System.Drawing.Point(244, 242);
            this.textville.Name = "textville";
            this.textville.Size = new System.Drawing.Size(100, 20);
            this.textville.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(381, 187);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(78, 13);
            this.textBox7.TabIndex = 15;
            this.textBox7.Text = "code postale :";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(396, 134);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(63, 13);
            this.textBox8.TabIndex = 16;
            this.textBox8.Text = "rue :";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(165, 242);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(73, 13);
            this.textBox9.TabIndex = 17;
            this.textBox9.Text = "ville :";
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged_1);
            // 
            // labelinfos
            // 
            this.labelinfos.AutoSize = true;
            this.labelinfos.ForeColor = System.Drawing.Color.Red;
            this.labelinfos.Location = new System.Drawing.Point(342, 305);
            this.labelinfos.Name = "labelinfos";
            this.labelinfos.Size = new System.Drawing.Size(0, 13);
            this.labelinfos.TabIndex = 18;
            this.labelinfos.Click += new System.EventHandler(this.label1_Click);
            // 
            // FConsultermesinfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelinfos);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textville);
            this.Controls.Add(this.textcodepostale);
            this.Controls.Add(this.textrue);
            this.Controls.Add(this.prénom);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textprenom);
            this.Controls.Add(this.textnom);
            this.Controls.Add(this.dgvconsultermesinfos);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.button1);
            this.Name = "FConsultermesinfos";
            this.Text = "FConsultermesinfos";
            this.Load += new System.EventHandler(this.FConsultermesinfos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultermesinfos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.TextBox textnom;
        private System.Windows.Forms.TextBox textprenom;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox prénom;
        private System.Windows.Forms.DataGridView dgvconsultermesinfos;
        private System.Windows.Forms.TextBox textrue;
        private System.Windows.Forms.TextBox textcodepostale;
        private System.Windows.Forms.TextBox textville;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label labelinfos;
    }
}