namespace GSB_FINAL
{
    partial class FMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionVisiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mission2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mission3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesVisiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionVisiteursToolStripMenuItem,
            this.gestionDesVisiteursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionVisiteursToolStripMenuItem
            // 
            this.gestionVisiteursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mission2ToolStripMenuItem,
            this.mission3ToolStripMenuItem});
            this.gestionVisiteursToolStripMenuItem.Name = "gestionVisiteursToolStripMenuItem";
            this.gestionVisiteursToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.gestionVisiteursToolStripMenuItem.Text = "Mission 1";
            this.gestionVisiteursToolStripMenuItem.Click += new System.EventHandler(this.gestionVisiteursToolStripMenuItem_Click);
            // 
            // mission2ToolStripMenuItem
            // 
            this.mission2ToolStripMenuItem.Name = "mission2ToolStripMenuItem";
            this.mission2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mission2ToolStripMenuItem.Text = "Mission 2";
            this.mission2ToolStripMenuItem.Click += new System.EventHandler(this.mission2ToolStripMenuItem_Click);
            // 
            // mission3ToolStripMenuItem
            // 
            this.mission3ToolStripMenuItem.Name = "mission3ToolStripMenuItem";
            this.mission3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mission3ToolStripMenuItem.Text = "Mission 3";
            this.mission3ToolStripMenuItem.Click += new System.EventHandler(this.mission3ToolStripMenuItem_Click);
            // 
            // gestionDesVisiteursToolStripMenuItem
            // 
            this.gestionDesVisiteursToolStripMenuItem.Name = "gestionDesVisiteursToolStripMenuItem";
            this.gestionDesVisiteursToolStripMenuItem.ShowShortcutKeys = false;
            this.gestionDesVisiteursToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.gestionDesVisiteursToolStripMenuItem.Text = "Gestion des visiteurs";
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenu";
            this.Text = "FMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionVisiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mission2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mission3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesVisiteursToolStripMenuItem;
    }
}

