namespace GSB_FINAL
{
    partial class FMission1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMission1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consulterMesInfosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTERMESRESPONSABILIT2SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mofierLeModDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserLesVisiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.bsGestionvisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGestionvisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterMesInfosToolStripMenuItem,
            this.cONSULTERMESRESPONSABILIT2SToolStripMenuItem,
            this.mofierLeModDePasseToolStripMenuItem,
            this.visualiserLesVisiteursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consulterMesInfosToolStripMenuItem
            // 
            this.consulterMesInfosToolStripMenuItem.Name = "consulterMesInfosToolStripMenuItem";
            this.consulterMesInfosToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.consulterMesInfosToolStripMenuItem.Text = "consulter mes infos";
            this.consulterMesInfosToolStripMenuItem.Click += new System.EventHandler(this.consulterMesInfosToolStripMenuItem_Click_1);
            // 
            // cONSULTERMESRESPONSABILIT2SToolStripMenuItem
            // 
            this.cONSULTERMESRESPONSABILIT2SToolStripMenuItem.Name = "cONSULTERMESRESPONSABILIT2SToolStripMenuItem";
            this.cONSULTERMESRESPONSABILIT2SToolStripMenuItem.Size = new System.Drawing.Size(174, 20);
            this.cONSULTERMESRESPONSABILIT2SToolStripMenuItem.Text = "consulter mes responsabilités";
            this.cONSULTERMESRESPONSABILIT2SToolStripMenuItem.Click += new System.EventHandler(this.cONSULTERMESRESPONSABILIT2SToolStripMenuItem_Click);
            // 
            // mofierLeModDePasseToolStripMenuItem
            // 
            this.mofierLeModDePasseToolStripMenuItem.Name = "mofierLeModDePasseToolStripMenuItem";
            this.mofierLeModDePasseToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.mofierLeModDePasseToolStripMenuItem.Text = "modifier le mot de passe";
            this.mofierLeModDePasseToolStripMenuItem.Click += new System.EventHandler(this.mofierLeModDePasseToolStripMenuItem_Click);
            // 
            // visualiserLesVisiteursToolStripMenuItem
            // 
            this.visualiserLesVisiteursToolStripMenuItem.Name = "visualiserLesVisiteursToolStripMenuItem";
            this.visualiserLesVisiteursToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.visualiserLesVisiteursToolStripMenuItem.Text = "visualiser les visiteurs";
            this.visualiserLesVisiteursToolStripMenuItem.Click += new System.EventHandler(this.visualiserLesVisiteursToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(296, 213);
            this.label1.MaximumSize = new System.Drawing.Size(200, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "BIENVENUE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bsGestionvisiteur
            // 
            this.bsGestionvisiteur.CurrentChanged += new System.EventHandler(this.bsGestionvisiteur_CurrentChanged);
            // 
            // FMission1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMission1";
            this.Text = "FMission1";
            this.Load += new System.EventHandler(this.FMission1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGestionvisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource bsGestionvisiteur;
        private System.Windows.Forms.ToolStripMenuItem consulterMesInfosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTERMESRESPONSABILIT2SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mofierLeModDePasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserLesVisiteursToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}