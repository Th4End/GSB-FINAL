namespace GSB_FINAL
{
    partial class Fconsultermesresponsabilités
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fconsultermesresponsabilités));
            this.dgvregionsresp = new System.Windows.Forms.DataGridView();
            this.bsResponsabilites = new System.Windows.Forms.BindingSource(this.components);
            this.dgvregionstrav = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bsregionsres = new System.Windows.Forms.BindingSource(this.components);
            this.bsregionstravai = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvregionsresp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResponsabilites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvregionstrav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsregionsres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsregionstravai)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvregionsresp
            // 
            this.dgvregionsresp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvregionsresp.Location = new System.Drawing.Point(109, 115);
            this.dgvregionsresp.Name = "dgvregionsresp";
            this.dgvregionsresp.Size = new System.Drawing.Size(201, 263);
            this.dgvregionsresp.TabIndex = 0;
            // 
            // dgvregionstrav
            // 
            this.dgvregionstrav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvregionstrav.Location = new System.Drawing.Point(457, 115);
            this.dgvregionstrav.Name = "dgvregionstrav";
            this.dgvregionstrav.Size = new System.Drawing.Size(209, 263);
            this.dgvregionstrav.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mes Responsabilités";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mes Regions ou lesquelles je suis responsable :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(469, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Regions ou je travaille :";
            // 
            // Fconsultermesresponsabilités
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvregionstrav);
            this.Controls.Add(this.dgvregionsresp);
            this.Name = "Fconsultermesresponsabilités";
            this.Text = "Fconsultermesresponsabilités";
            this.Load += new System.EventHandler(this.Fconsultermesresponsabilités_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvregionsresp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResponsabilites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvregionstrav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsregionsres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsregionstravai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvregionsresp;
        private System.Windows.Forms.BindingSource bsResponsabilites;
        private System.Windows.Forms.DataGridView dgvregionstrav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bsregionsres;
        private System.Windows.Forms.BindingSource bsregionstravai;
    }
}