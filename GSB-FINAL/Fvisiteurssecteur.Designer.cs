namespace GSB_FINAL
{
    partial class Fvisiteurssecteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fvisiteurssecteur));
            this.dgvvisiteursecteur = new System.Windows.Forms.DataGridView();
            this.cbosecteurs = new System.Windows.Forms.ComboBox();
            this.bssecteur = new System.Windows.Forms.BindingSource(this.components);
            this.bsregion = new System.Windows.Forms.BindingSource(this.components);
            this.bsvisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.cboregions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecteur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvisiteursecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bssecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsregion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsvisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvvisiteursecteur
            // 
            this.dgvvisiteursecteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvisiteursecteur.Location = new System.Drawing.Point(345, 35);
            this.dgvvisiteursecteur.Name = "dgvvisiteursecteur";
            this.dgvvisiteursecteur.Size = new System.Drawing.Size(414, 391);
            this.dgvvisiteursecteur.TabIndex = 0;
            // 
            // cbosecteurs
            // 
            this.cbosecteurs.FormattingEnabled = true;
            this.cbosecteurs.Location = new System.Drawing.Point(33, 57);
            this.cbosecteurs.Name = "cbosecteurs";
            this.cbosecteurs.Size = new System.Drawing.Size(121, 21);
            this.cbosecteurs.TabIndex = 1;
            // 
            // bssecteur
            // 
            this.bssecteur.CurrentChanged += new System.EventHandler(this.bssecteur_CurrentChanged);
            // 
            // bsregion
            // 
            this.bsregion.CurrentChanged += new System.EventHandler(this.bsregion_CurrentChanged);
            // 
            // cboregions
            // 
            this.cboregions.FormattingEnabled = true;
            this.cboregions.Location = new System.Drawing.Point(33, 162);
            this.cboregions.Name = "cboregions";
            this.cboregions.Size = new System.Drawing.Size(121, 21);
            this.cboregions.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Secteurs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Regions";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSecteur
            // 
            this.txtSecteur.AutoSize = true;
            this.txtSecteur.Location = new System.Drawing.Point(30, 97);
            this.txtSecteur.Name = "txtSecteur";
            this.txtSecteur.Size = new System.Drawing.Size(0, 13);
            this.txtSecteur.TabIndex = 5;
            // 
            // Fvisiteurssecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSecteur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboregions);
            this.Controls.Add(this.cbosecteurs);
            this.Controls.Add(this.dgvvisiteursecteur);
            this.Name = "Fvisiteurssecteur";
            this.Text = "Fvisiteurssecteur";
            this.Load += new System.EventHandler(this.Fvisiteurssecteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvisiteursecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bssecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsregion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsvisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvvisiteursecteur;
        private System.Windows.Forms.ComboBox cbosecteurs;
        private System.Windows.Forms.BindingSource bssecteur;
        private System.Windows.Forms.BindingSource bsregion;
        private System.Windows.Forms.BindingSource bsvisiteur;
        private System.Windows.Forms.ComboBox cboregions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtSecteur;
    }
}