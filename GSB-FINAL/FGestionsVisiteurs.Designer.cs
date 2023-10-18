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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bsGestionvisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pourSalariéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterMesInfosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesResponsabilitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGestionvisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pourSalariéToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(78, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 232);
            this.dataGridView1.TabIndex = 1;
            // 
            // pourSalariéToolStripMenuItem
            // 
            this.pourSalariéToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterMesInfosToolStripMenuItem,
            this.mesResponsabilitésToolStripMenuItem,
            this.modifMotDePasseToolStripMenuItem});
            this.pourSalariéToolStripMenuItem.Name = "pourSalariéToolStripMenuItem";
            this.pourSalariéToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.pourSalariéToolStripMenuItem.Text = "Salarié";
            // 
            // consulterMesInfosToolStripMenuItem
            // 
            this.consulterMesInfosToolStripMenuItem.Name = "consulterMesInfosToolStripMenuItem";
            this.consulterMesInfosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consulterMesInfosToolStripMenuItem.Text = "consulter mes infos";
            // 
            // mesResponsabilitésToolStripMenuItem
            // 
            this.mesResponsabilitésToolStripMenuItem.Name = "mesResponsabilitésToolStripMenuItem";
            this.mesResponsabilitésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mesResponsabilitésToolStripMenuItem.Text = "mes responsabilités";
            // 
            // modifMotDePasseToolStripMenuItem
            // 
            this.modifMotDePasseToolStripMenuItem.Name = "modifMotDePasseToolStripMenuItem";
            this.modifMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifMotDePasseToolStripMenuItem.Text = "modif mot de passe";
            // 
            // FMission1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMission1";
            this.Text = "FMission1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGestionvisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource bsGestionvisiteur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem pourSalariéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterMesInfosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesResponsabilitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifMotDePasseToolStripMenuItem;
    }
}