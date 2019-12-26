namespace App
{
    partial class FormCv
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
            this.buttonGenererPdf = new System.Windows.Forms.Button();
            this.panelForme = new System.Windows.Forms.Panel();
            this.panelFond = new System.Windows.Forms.Panel();
            this.pictureBoxApercuCv = new System.Windows.Forms.PictureBox();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.panelApercu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApercuCv)).BeginInit();
            this.panelApercu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenererPdf
            // 
            this.buttonGenererPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenererPdf.BackColor = System.Drawing.Color.White;
            this.buttonGenererPdf.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.buttonGenererPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenererPdf.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenererPdf.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonGenererPdf.Location = new System.Drawing.Point(930, 714);
            this.buttonGenererPdf.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGenererPdf.Name = "buttonGenererPdf";
            this.buttonGenererPdf.Size = new System.Drawing.Size(300, 63);
            this.buttonGenererPdf.TabIndex = 0;
            this.buttonGenererPdf.Text = "Générer le pdf";
            this.buttonGenererPdf.UseVisualStyleBackColor = false;
            this.buttonGenererPdf.Click += new System.EventHandler(this.buttonGenererPdf_Click);
            // 
            // panelForme
            // 
            this.panelForme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForme.BackColor = System.Drawing.SystemColors.Control;
            this.panelForme.Location = new System.Drawing.Point(930, 12);
            this.panelForme.Name = "panelForme";
            this.panelForme.Size = new System.Drawing.Size(300, 695);
            this.panelForme.TabIndex = 3;
            // 
            // panelFond
            // 
            this.panelFond.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelFond.AutoScroll = true;
            this.panelFond.BackColor = System.Drawing.SystemColors.Control;
            this.panelFond.Location = new System.Drawing.Point(13, 83);
            this.panelFond.Name = "panelFond";
            this.panelFond.Size = new System.Drawing.Size(300, 694);
            this.panelFond.TabIndex = 4;
            // 
            // pictureBoxApercuCv
            // 
            this.pictureBoxApercuCv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxApercuCv.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxApercuCv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxApercuCv.Location = new System.Drawing.Point(17, 0);
            this.pictureBoxApercuCv.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxApercuCv.Name = "pictureBoxApercuCv";
            this.pictureBoxApercuCv.Size = new System.Drawing.Size(560, 766);
            this.pictureBoxApercuCv.TabIndex = 5;
            this.pictureBoxApercuCv.TabStop = false;
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.Color.White;
            this.buttonRetour.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetour.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonRetour.Location = new System.Drawing.Point(13, 13);
            this.buttonRetour.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(300, 63);
            this.buttonRetour.TabIndex = 6;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // panelApercu
            // 
            this.panelApercu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelApercu.Controls.Add(this.pictureBoxApercuCv);
            this.panelApercu.Location = new System.Drawing.Point(324, 12);
            this.panelApercu.Name = "panelApercu";
            this.panelApercu.Size = new System.Drawing.Size(594, 766);
            this.panelApercu.TabIndex = 9;
            this.panelApercu.SizeChanged += new System.EventHandler(this.panelApercu_SizeChanged);
            // 
            // FormCv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1242, 791);
            this.Controls.Add(this.panelApercu);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.buttonGenererPdf);
            this.Controls.Add(this.panelFond);
            this.Controls.Add(this.panelForme);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1260, 838);
            this.Name = "FormCv";
            this.Text = "Designer de CV";
            this.Load += new System.EventHandler(this.panelApercu_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApercuCv)).EndInit();
            this.panelApercu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenererPdf;
        private System.Windows.Forms.Panel panelForme;
        private System.Windows.Forms.Panel panelFond;
        private System.Windows.Forms.PictureBox pictureBoxApercuCv;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Panel panelApercu;
    }
}

